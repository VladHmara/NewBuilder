using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewBuilder.Common
{
    static class ActiveCurrentWindow
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        static public dynamic MyWindowIsActive()
        {
            var test = GetForegroundWindow();
            return test;
        }

    }
}
