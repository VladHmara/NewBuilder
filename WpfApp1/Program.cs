using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace ToTray
{
    //static class Program
    //{
    //    /// <summary>
    //    /// The main entry point for the application.
    //    /// </summary>
    //    [STAThread]
    //    static int Main(string[] args)
    //    {
    //        Application.EnableVisualStyles();
    //        Application.SetCompatibleTextRenderingDefault(false);

    //        using (var frm = new frmMain())
    //        {
    //            frm.HotKeyId = 0x32;
    //            frm.FormClosed += (s, e) => {
    //                HotKeys.Unregister(frm, frm.HotKeyId);
    //            };

    //            HotKeys.Register(frm, frm.HotKeyId, Modifiers.ALT, Keys.PrintScreen);
    //            Application.Run(frm);
    //        }

    //        return 0; // OK
    //    }
    //}
}