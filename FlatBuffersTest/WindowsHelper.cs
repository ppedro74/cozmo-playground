using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FlatBuffersTest
{
    internal static class WindowsHelper
    {
        private const int WM_VSCROLL = 0x115;

        private const int SB_BOTTOM = 7;

        private static readonly Lazy<bool> IsRunningOnMonoValue = new Lazy<bool>(() => { return Type.GetType("Mono.Runtime") != null; });

        public static bool IsRunningOnMono()
        {
            return IsRunningOnMonoValue.Value;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// Scrolls the vertical scroll bar of a multi-line text box to the bottom.
        /// </summary>
        /// <param name="control">The text box to scroll</param>
        public static void ScrollToBottom(Control control)
        {
            if (false == IsRunningOnMono())
            {
                SendMessage(control.Handle, WM_VSCROLL, (IntPtr)SB_BOTTOM, IntPtr.Zero);
            }
        }
    }
}