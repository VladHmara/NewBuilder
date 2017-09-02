using System.Windows.Forms;
using System.Diagnostics;
using System;
using System.Runtime.InteropServices;

namespace ToTray
{
    public partial class frmMain : Form
    {
        const int WM_HOTKEY = 0x0312;

        public frmMain()
        {
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HotKeyId)
            {
                MessageBox.Show("WM_HOTKEY: " + m);
            }
            base.WndProc(ref m);
        }

        public int HotKeyId { get; set; }
    }
}
