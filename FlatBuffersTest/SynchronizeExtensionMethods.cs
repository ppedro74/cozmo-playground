using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace FlatBuffersTest
{
    internal static class SynchronizeExtensionMethods
    {
        public static void SynchronizedInvoke(this ISynchronizeInvoke sync, Action action)
        {
            // If the invoke is not required, then invoke here and get out.
            if (!sync.InvokeRequired)
            {
                // Execute action.
                action();

                // Get out.
                return;
            }

            // Marshal to the required context.
            sync.Invoke(action, new object[] { });
        }

        public static bool ThreadSafeGetEnabled(this Control control)
        {
            if (control.InvokeRequired)
            {
                return (bool)control.Invoke(new GetControlBoolPropertyDelegate(ThreadSafeGetEnabled), control);
            }

            return control.Enabled;
        }

        public static void ThreadSafeSetEnabled(this Control control, bool enable)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlBoolPropertyDelegate(ThreadSafeSetEnabled), control, enable);
            }
            else
            {
                control.Enabled = enable;
            }
        }

        public static bool ThreadSafeGetVisible(this Control control)
        {
            if (control.InvokeRequired)
            {
                return (bool)control.Invoke(new GetControlBoolPropertyDelegate(ThreadSafeGetEnabled), control);
            }

            return control.Visible;
        }

        public static void ThreadSafeSetVisible(this Control control, bool visible)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlBoolPropertyDelegate(ThreadSafeSetVisible), control, visible);
            }
            else
            {
                control.Visible = visible;
            }
        }

        public static string ThreadSafeGetText(this Control control)
        {
            if (control.InvokeRequired)
            {
                return (string)control.Invoke(new GetControlStringPropertyDelegate(ThreadSafeGetText), control);
            }

            return control.Text;
        }

        public static void ThreadSafeSetText(this Control control, string text)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlStringPropertyDelegate(ThreadSafeSetText), control, text);
            }
            else
            {
                control.Text = text;
            }
        }

        public static int ThreadSafeGetSelectedIndex(this ListControl listControl)
        {
            if (listControl.InvokeRequired)
            {
                return (int)listControl.Invoke(new GetListControlGetIntPropertyDelegate(ThreadSafeGetSelectedIndex), listControl);
            }

            return listControl.SelectedIndex;
        }

        public static void ThreadSafeSetSelectedIndex(this ListControl listControl, int index)
        {
            if (listControl.InvokeRequired)
            {
                listControl.Invoke(new SetListControlIntPropertyDelegate(ThreadSafeSetSelectedIndex), listControl, index);
            }
            else
            {
                listControl.SelectedIndex = index;
            }
        }

        public static TabPage ThreadSafeGetSelectedTab(this TabControl tabControl)
        {
            if (tabControl.InvokeRequired)
            {
                return (TabPage)tabControl.Invoke(new GetTabControlTabPagePropertyDelegate(ThreadSafeGetSelectedTab), tabControl);
            }

            return tabControl.SelectedTab;
        }

        public static void ThreadSafeSetItems(this ComboBox comboBox, bool isAppend, IEnumerable<string> texts)
        {
            if (comboBox.InvokeRequired)
            {
                comboBox.Invoke(new SetComboBoxStringsPropertyDelegate(ThreadSafeSetItems), comboBox, isAppend, texts);
            }
            else
            {
                if (!isAppend)
                {
                    comboBox.Items.Clear();
                }

                if (texts != null)
                {
                    foreach (var text in texts)
                    {
                        comboBox.Items.Add(text);
                    }
                }
            }
        }

        public static object ThreadSafeGetSelectedItem(this ComboBox comboBox)
        {
            if (comboBox.InvokeRequired)
            {
                return comboBox.Invoke(new GetComboBoxObjectPropertyDelegate(ThreadSafeGetSelectedItem), comboBox);
            }

            return comboBox.SelectedItem;
        }

        public static void ThreadSafeSetSelectedItem(this ComboBox comboBox, object item)
        {
            if (comboBox.InvokeRequired)
            {
                comboBox.Invoke(new SetComboBoxObjectPropertyDelegate(ThreadSafeSetSelectedItem), comboBox, item);
            }
            else
            {
                comboBox.SelectedItem = item;
            }
        }

        private delegate object GetComboBoxObjectPropertyDelegate(ComboBox comboBox);

        private delegate bool GetControlBoolPropertyDelegate(Control control);

        private delegate string GetControlStringPropertyDelegate(Control control);

        private delegate int GetListControlGetIntPropertyDelegate(ListControl listControl);

        private delegate TabPage GetTabControlTabPagePropertyDelegate(TabControl tabControl);

        private delegate void SetComboBoxObjectPropertyDelegate(ComboBox comboBox, object item);

        private delegate void SetComboBoxStringsPropertyDelegate(ComboBox comboBox, bool isAppend, IEnumerable<string> texts);

        private delegate void SetControlBoolPropertyDelegate(Control control, bool value);

        private delegate void SetControlStringPropertyDelegate(Control control, string value);

        private delegate void SetListControlIntPropertyDelegate(ListControl listControl, int value);
    }
}