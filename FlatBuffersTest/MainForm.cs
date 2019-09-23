using System;
using System.Globalization;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;
using CozmoAnim;
using FlatBuffers;

namespace FlatBuffersTest
{
    public partial class MainForm : Form
    {
        private class Context
        {
            public string Name { get; set; }

            public long FileLength { get; set; }

            public Tuple<int, AnimClip> AnimClip { get; set; }

            public Tuple<int, ProceduralFace> ProceduralFace { get; set; }

            public Cozmo.ProceduralFace ProceduralFaceModel { get; set; }

            public Action<Context> RunProceduralFaceAction { get; set; }

            public Action<Context> RunKeyFramesAction { get; set; }
        }

        private bool quit;

        public MainForm()
        {
            this.InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            this.InputFolderTextBox.Text = Utils.GetRelativePath(Utils.EnsurePathExists(Properties.Settings.Default.InputFolder));
            this.OutputFolderTextBox.Text = Utils.GetRelativePath(Utils.EnsurePathExists(Properties.Settings.Default.OutputFolder));
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.quit = true;
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            try
            {
                var inputFolder = Utils.GetFullPath(this.InputFolderTextBox.Text);

                this.filesListView.Items.Clear();

                var csvFile = Path.Combine(Utils.GetFullPath(this.OutputFolderTextBox.Text), "AllProcFaces.csv");
                using (var streamWriter = new StreamWriter(csvFile))
                {
                    streamWriter.WriteLine("FileName,Name," + Cozmo.ProceduralFace.ToCsvHeader());

                    var context = new Context()
                    {
                        RunProceduralFaceAction = (ctx) =>
                        {
                            streamWriter.WriteLine(ctx.Name + "," + ctx.AnimClip.Item2.Name + "," + ctx.ProceduralFaceModel.ToCsv());
                        },
                        RunKeyFramesAction = (ctx) =>
                        {
                            var item = new ListViewItem(ctx.Name);
                            item.SubItems.Add(ctx.FileLength.ToString());
                            item.SubItems.Add(ctx.AnimClip.Item2.Keyframes?.ProceduralFaceKeyFrameLength.ToString());
                            item.SubItems.Add(ctx.AnimClip.Item2.Keyframes?.LiftHeightKeyFrameLength.ToString());
                            item.SubItems.Add(ctx.AnimClip.Item2.Keyframes?.HeadAngleKeyFrameLength.ToString());
                            item.SubItems.Add(ctx.AnimClip.Item2.Keyframes?.RobotAudioKeyFrameLength.ToString());
                            item.SubItems.Add(ctx.AnimClip.Item2.Keyframes?.BackpackLightsKeyFrameLength.ToString());
                            item.SubItems.Add(ctx.AnimClip.Item2.Keyframes?.FaceAnimationKeyFrameLength.ToString());
                            item.SubItems.Add(ctx.AnimClip.Item2.Keyframes?.FaceAnimationKeyFrameLength.ToString());
                            item.SubItems.Add(ctx.AnimClip.Item2.Keyframes?.EventKeyFrameLength.ToString());
                            item.SubItems.Add(ctx.AnimClip.Item2.Keyframes?.BodyMotionKeyFrameLength.ToString());
                            item.SubItems.Add(ctx.AnimClip.Item2.Keyframes?.TurnToRecordedHeadingKeyFrameLength.ToString());
                            this.filesListView.Items.Add(item);
                        }
                    };

                    Utils.EnumerateFiles(
                        Utils.GetFullPath(this.InputFolderTextBox.Text),
                        "*.bin",
                        SearchOption.AllDirectories,
                        fi =>
                        {
                            var name = Utils.GetRelativePath(fi.FullName, inputFolder);

                            context.Name = name;
                            context.FileLength = fi.Length;
                            var animClips = ProcessAnimFile(fi.FullName, context);

                            //continue
                            return true;
                        });
                }
                this.Log(LogLevel.Info, "csv file generated: " + csvFile);
            }
            catch (Exception ex)
            {
                this.Log(LogLevel.Error, ex);
            }
            finally
            {
                ((Button)sender).Enabled = true;
            }
        }

        private static AnimClips ProcessAnimFile(string fileName, Context ctx)
        {
            var bytes = File.ReadAllBytes(fileName);
            var buf = new ByteBuffer(bytes);
            var animClips = AnimClips.GetRootAsAnimClips(buf);
            for (var ix = 0; ix < animClips.ClipsLength; ix++)
            {
                var animClip = animClips.Clips(ix);
                if (animClip != null)
                {
                    ProcessAnimClip(ix, animClip.Value, ctx);
                }
            }

            return animClips;
        }

        private static void ProcessAnimClip(int animClipIx, AnimClip animClip, Context ctx)
        {
            ctx.AnimClip = new Tuple<int, AnimClip>(animClipIx, animClip);

            var keyframes = animClip.Keyframes;
            if (keyframes == null)
            {
                return;
            }

            ctx.RunKeyFramesAction(ctx);

            for (var ix = 0; ix < keyframes.Value.ProceduralFaceKeyFrameLength; ix++)
            {
                var proceduralFace = keyframes.Value.ProceduralFaceKeyFrame(ix);
                if (proceduralFace != null)
                {
                    ProcessProceduralFace(ix, proceduralFace.Value, ctx);
                }
            }
        }

        private static void ProcessProceduralFace(int keyFrameIx, ProceduralFace proceduralFace, Context ctx)
        {
            ctx.ProceduralFace = new Tuple<int, ProceduralFace>(keyFrameIx, proceduralFace);
            ctx.ProceduralFaceModel = new Cozmo.ProceduralFace(proceduralFace);
            ctx.RunProceduralFaceAction(ctx);
        }

        private void Log(LogLevel logLevel, object obj)
        {
            this.Log(logLevel, obj, false);
        }

        private void Log(LogLevel logLevel, object obj, bool clear)
        {
            if (!this.IsHandleCreated)
            {
                //no handle yet
                return;
            }

            if (this.quit)
            {
                //exit
                return;
            }

            var text = obj is Exception ? " Exception=[\r\n" + obj + "]" : obj.ToString();

            this.LogTextBox.SynchronizedInvoke(
                () =>
                {
                    if (clear)
                    {
                        this.LogTextBox.Text = string.Empty;
                    }

                    if (this.LogTextBox.Text.Length > 4096)
                    {
                        this.LogTextBox.Text = "*** Auto Clear ***\r\n";
                    }

                    this.LogTextBox.Text = this.LogTextBox.Text + DateTime.Now.ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture) + ">" + logLevel + ">>" + text + "\r\n";

                    if (this.AutoScrollCB.Checked)
                    {
                        this.LogTextBox.SelectionLength = 0;
                        this.LogTextBox.SelectionStart = this.LogTextBox.Text.Length;
                        //this.LogTextBox.ScrollToCaret();
                        WindowsHelper.ScrollToBottom(this.LogTextBox);
                    }
                });
        }

        public static void ShowOpenFolderDialog(string title, TextBox textBox, Action<string> folderAction = null)
        {
            string initialDirectory;

            initialDirectory = string.IsNullOrEmpty(textBox.Text) ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) : Utils.GetFullPath(textBox.Text);

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.FileName = "Filename will be ignored";
            //openFileDialog.CheckPathExists = true;
            //openFileDialog.ShowReadOnly = false;
            //openFileDialog.ReadOnlyChecked = true;
            //openFileDialog.CheckFileExists = false;
            //openFileDialog.ValidateNames = false;
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    textBox.Text = Path.GetFullPath(openFileDialog.FileName);
            //}

            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = initialDirectory;
                folderBrowserDialog.Description = title;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = Utils.GetRelativePath(folderBrowserDialog.SelectedPath);
                    folderAction?.Invoke(folderBrowserDialog.SelectedPath);
                }
            }
        }

        private void BrowseInputDirectoryButton_Click(object sender, EventArgs e)
        {
            ShowOpenFolderDialog(
                "Select Input Folder",
                this.InputFolderTextBox,
                f =>
                {
                    Properties.Settings.Default.InputFolder = f;
                    Properties.Settings.Default.Save();
                });
        }

        private void BrowseOutputDirectoryButton_Click(object sender, EventArgs e)
        {
            ShowOpenFolderDialog(
                "Select Output Folder",
                this.OutputFolderTextBox,
                f =>
                {
                    Properties.Settings.Default.OutputFolder = f;
                    Properties.Settings.Default.Save();
                });
        }

        private void ClearDebugButton_Click(object sender, EventArgs e)
        {
            this.LogTextBox.Text = "";
        }
    }
}