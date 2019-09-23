namespace FlatBuffersTest
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AutoScrollCB = new System.Windows.Forms.CheckBox();
            this.ClearDebugButton = new System.Windows.Forms.Button();
            this.LogBottomControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.LogGroupBox = new System.Windows.Forms.GroupBox();
            this.DebugTabPage = new System.Windows.Forms.TabPage();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.FilesTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.OptionsTabControl = new System.Windows.Forms.TabControl();
            this.ScanTabPage = new System.Windows.Forms.TabPage();
            this.BrowseOutputDirectoryButton = new System.Windows.Forms.Button();
            this.OutputFolderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BrowseInputDirectoryButton = new System.Windows.Forms.Button();
            this.ScanButton = new System.Windows.Forms.Button();
            this.InputFolderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LogBottomControlsGroupBox.SuspendLayout();
            this.LogGroupBox.SuspendLayout();
            this.DebugTabPage.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.FilesTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.OptionsTabControl.SuspendLayout();
            this.ScanTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoScrollCB
            // 
            this.AutoScrollCB.AutoSize = true;
            this.AutoScrollCB.Checked = true;
            this.AutoScrollCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoScrollCB.Location = new System.Drawing.Point(84, 14);
            this.AutoScrollCB.Name = "AutoScrollCB";
            this.AutoScrollCB.Size = new System.Drawing.Size(77, 17);
            this.AutoScrollCB.TabIndex = 9;
            this.AutoScrollCB.Text = "Auto Scroll";
            this.AutoScrollCB.UseVisualStyleBackColor = true;
            // 
            // ClearDebugButton
            // 
            this.ClearDebugButton.Location = new System.Drawing.Point(3, 10);
            this.ClearDebugButton.Name = "ClearDebugButton";
            this.ClearDebugButton.Size = new System.Drawing.Size(75, 23);
            this.ClearDebugButton.TabIndex = 8;
            this.ClearDebugButton.Text = "Clear";
            this.ClearDebugButton.UseVisualStyleBackColor = true;
            this.ClearDebugButton.Click += new System.EventHandler(this.ClearDebugButton_Click);
            // 
            // LogBottomControlsGroupBox
            // 
            this.LogBottomControlsGroupBox.Controls.Add(this.AutoScrollCB);
            this.LogBottomControlsGroupBox.Controls.Add(this.ClearDebugButton);
            this.LogBottomControlsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogBottomControlsGroupBox.Location = new System.Drawing.Point(3, 287);
            this.LogBottomControlsGroupBox.Name = "LogBottomControlsGroupBox";
            this.LogBottomControlsGroupBox.Size = new System.Drawing.Size(718, 41);
            this.LogBottomControlsGroupBox.TabIndex = 5;
            this.LogBottomControlsGroupBox.TabStop = false;
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.Color.Black;
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogTextBox.ForeColor = System.Drawing.Color.White;
            this.LogTextBox.Location = new System.Drawing.Point(3, 16);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(712, 265);
            this.LogTextBox.TabIndex = 6;
            this.LogTextBox.WordWrap = false;
            // 
            // LogGroupBox
            // 
            this.LogGroupBox.Controls.Add(this.LogTextBox);
            this.LogGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogGroupBox.Location = new System.Drawing.Point(3, 3);
            this.LogGroupBox.Name = "LogGroupBox";
            this.LogGroupBox.Size = new System.Drawing.Size(718, 284);
            this.LogGroupBox.TabIndex = 5;
            this.LogGroupBox.TabStop = false;
            // 
            // DebugTabPage
            // 
            this.DebugTabPage.Controls.Add(this.LogGroupBox);
            this.DebugTabPage.Controls.Add(this.LogBottomControlsGroupBox);
            this.DebugTabPage.Location = new System.Drawing.Point(4, 22);
            this.DebugTabPage.Name = "DebugTabPage";
            this.DebugTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DebugTabPage.Size = new System.Drawing.Size(724, 331);
            this.DebugTabPage.TabIndex = 1;
            this.DebugTabPage.Text = "Debug";
            this.DebugTabPage.UseVisualStyleBackColor = true;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.DebugTabPage);
            this.MainTabControl.Controls.Add(this.FilesTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 126);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(732, 357);
            this.MainTabControl.TabIndex = 6;
            // 
            // FilesTabPage
            // 
            this.FilesTabPage.Controls.Add(this.groupBox1);
            this.FilesTabPage.Controls.Add(this.groupBox2);
            this.FilesTabPage.Location = new System.Drawing.Point(4, 22);
            this.FilesTabPage.Name = "FilesTabPage";
            this.FilesTabPage.Size = new System.Drawing.Size(724, 331);
            this.FilesTabPage.TabIndex = 2;
            this.FilesTabPage.Text = "Files";
            this.FilesTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filesListView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 290);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // filesListView
            // 
            this.filesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.filesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesListView.HideSelection = false;
            this.filesListView.Location = new System.Drawing.Point(3, 16);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(718, 271);
            this.filesListView.TabIndex = 11;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 187;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FileLength";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "# ProceduralFace";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "# LiftHeight";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "# HeadAngle";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "# RobotAudio";
            this.columnHeader6.Width = 82;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "# BackpackLights";
            this.columnHeader7.Width = 106;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "# FaceAnimation";
            this.columnHeader8.Width = 93;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "# Event";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 53;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "# BodyMotion";
            this.columnHeader10.Width = 81;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "# RecordHeading";
            this.columnHeader11.Width = 101;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "# TurnToRecordedHeading";
            this.columnHeader12.Width = 145;
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 41);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.OptionsTabControl);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(732, 126);
            this.TopPanel.TabIndex = 5;
            // 
            // OptionsTabControl
            // 
            this.OptionsTabControl.Controls.Add(this.ScanTabPage);
            this.OptionsTabControl.Controls.Add(this.tabPage2);
            this.OptionsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsTabControl.Location = new System.Drawing.Point(0, 0);
            this.OptionsTabControl.Name = "OptionsTabControl";
            this.OptionsTabControl.SelectedIndex = 0;
            this.OptionsTabControl.Size = new System.Drawing.Size(732, 126);
            this.OptionsTabControl.TabIndex = 0;
            // 
            // ScanTabPage
            // 
            this.ScanTabPage.Controls.Add(this.BrowseOutputDirectoryButton);
            this.ScanTabPage.Controls.Add(this.OutputFolderTextBox);
            this.ScanTabPage.Controls.Add(this.label2);
            this.ScanTabPage.Controls.Add(this.BrowseInputDirectoryButton);
            this.ScanTabPage.Controls.Add(this.ScanButton);
            this.ScanTabPage.Controls.Add(this.InputFolderTextBox);
            this.ScanTabPage.Controls.Add(this.label1);
            this.ScanTabPage.Location = new System.Drawing.Point(4, 22);
            this.ScanTabPage.Name = "ScanTabPage";
            this.ScanTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ScanTabPage.Size = new System.Drawing.Size(724, 100);
            this.ScanTabPage.TabIndex = 0;
            this.ScanTabPage.Text = "Anims";
            this.ScanTabPage.UseVisualStyleBackColor = true;
            // 
            // BrowseOutputDirectoryButton
            // 
            this.BrowseOutputDirectoryButton.Location = new System.Drawing.Point(303, 39);
            this.BrowseOutputDirectoryButton.Name = "BrowseOutputDirectoryButton";
            this.BrowseOutputDirectoryButton.Size = new System.Drawing.Size(28, 20);
            this.BrowseOutputDirectoryButton.TabIndex = 16;
            this.BrowseOutputDirectoryButton.Text = "...";
            this.BrowseOutputDirectoryButton.UseVisualStyleBackColor = true;
            this.BrowseOutputDirectoryButton.Click += new System.EventHandler(this.BrowseOutputDirectoryButton_Click);
            // 
            // OutputFolderTextBox
            // 
            this.OutputFolderTextBox.Location = new System.Drawing.Point(80, 39);
            this.OutputFolderTextBox.Name = "OutputFolderTextBox";
            this.OutputFolderTextBox.Size = new System.Drawing.Size(217, 20);
            this.OutputFolderTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Output Folder:";
            // 
            // BrowseInputDirectoryButton
            // 
            this.BrowseInputDirectoryButton.Location = new System.Drawing.Point(756, 12);
            this.BrowseInputDirectoryButton.Name = "BrowseInputDirectoryButton";
            this.BrowseInputDirectoryButton.Size = new System.Drawing.Size(28, 20);
            this.BrowseInputDirectoryButton.TabIndex = 13;
            this.BrowseInputDirectoryButton.Text = "...";
            this.BrowseInputDirectoryButton.UseVisualStyleBackColor = true;
            this.BrowseInputDirectoryButton.Click += new System.EventHandler(this.BrowseInputDirectoryButton_Click);
            // 
            // ScanButton
            // 
            this.ScanButton.Location = new System.Drawing.Point(80, 65);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(128, 23);
            this.ScanButton.TabIndex = 12;
            this.ScanButton.Text = "Scan && Generate csv";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // InputFolderTextBox
            // 
            this.InputFolderTextBox.Location = new System.Drawing.Point(80, 13);
            this.InputFolderTextBox.Name = "InputFolderTextBox";
            this.InputFolderTextBox.Size = new System.Drawing.Size(670, 20);
            this.InputFolderTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Anim Folder:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(724, 100);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 483);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.TopPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LogBottomControlsGroupBox.ResumeLayout(false);
            this.LogBottomControlsGroupBox.PerformLayout();
            this.LogGroupBox.ResumeLayout(false);
            this.LogGroupBox.PerformLayout();
            this.DebugTabPage.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.FilesTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.OptionsTabControl.ResumeLayout(false);
            this.ScanTabPage.ResumeLayout(false);
            this.ScanTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox AutoScrollCB;
        private System.Windows.Forms.Button ClearDebugButton;
        private System.Windows.Forms.GroupBox LogBottomControlsGroupBox;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.GroupBox LogGroupBox;
        private System.Windows.Forms.TabPage DebugTabPage;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TabControl OptionsTabControl;
        private System.Windows.Forms.TabPage ScanTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ScanButton;
        private System.Windows.Forms.TextBox InputFolderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage FilesTabPage;
        private System.ComponentModel.BackgroundWorker BackgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BrowseInputDirectoryButton;
        private System.Windows.Forms.Button BrowseOutputDirectoryButton;
        private System.Windows.Forms.TextBox OutputFolderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}