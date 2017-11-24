using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewBuilder.Common
{
    public class Hook : IDisposable
    {
        #region Declare WinAPI functions
        [DllImport("kernel32.dll")]
        private static extern IntPtr LoadLibrary(string lpFileName);
        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, KeyboardHookProc callback, IntPtr hInstance, uint threadId);
        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hInstance);
        #endregion

        #region Constants
        const int WM_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;
        const int WM_KEYUP = 0x101;
        const int WM_SYSKEYDOWN = 0x104;
        const int WM_SYSKEYUP = 0x105;
        #endregion

        private delegate IntPtr KeyboardHookProc(int code, IntPtr wParam, IntPtr lParam);
        private KeyboardHookProc _proc;
        private IntPtr _hHook = IntPtr.Zero;

        private List<int> bufferKeyList = new List<int>();
        public bool flagNotRepeat = true;

        //getter bufferKeyList
        public string BufferKeyList()
        {
            return KeysCode.ListToString(bufferKeyList);

        }


        public Hook()
        {
            _proc = HookProc;
            SetHook();
        }

        public void SetHook()
        {
            var hInstance = LoadLibrary("User32");
            _hHook = SetWindowsHookEx(WM_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public void Dispose()
        {
            UnHook();
        }

        public void UnHook()
        {
            UnhookWindowsHookEx(_hHook);
        }

        private IntPtr HookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            
                if (wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN)
                {
                    if (!bufferKeyList.Contains(Marshal.ReadInt32(lParam)))
                        bufferKeyList.Add(Marshal.ReadInt32(lParam));
                }

                if (wParam == (IntPtr)WM_KEYUP || wParam == (IntPtr)WM_SYSKEYUP)
                {
                    bufferKeyList.Remove(Marshal.ReadInt32(lParam));
                }
                //MyWindowIsActive - returning IntPtr active window
                if (flagNotRepeat)// && ActiveCurrentWindow.MyWindowIsActive() == (IntPtr)0x000202c2)
                {
                    flagNotRepeat = false;
                    //if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN && Marshal.ReadInt32(lParam) == 0x57)
                    //{

                    //Thread t = new Thread(new ThreadStart(() =>
                    //{
                    //    lock (bufferKeyList)
                    //    {
                    //при проверки достаем весь список биндов и проверяем совпадение
                    // да - вызываем сендМесседж у бинда



                    if (bufferKeyList.Count != 0)
                        foreach (var item in Bind.Items)
                            if (item.Keys.SequenceEqual<int>(bufferKeyList))
                            {
                                item.SendMessage();
                                flagNotRepeat = true;
                                return (IntPtr)1;
                            }
                    //Keyboard temp = new Keyboard();
                    //temp.SendKeys(Marshal.ReadInt32(lParam).ToString(), true);


                    flagNotRepeat = true;

                    //    }

                    //}));
                    //t.Start();
                    // бросаем событие
                    //MessageBox.Show(wParam.ToString() + " " + Marshal.ReadInt32(lParam).ToString(), "Title");
                    //Bind.Method();
                    //}
                }

        
            // пробрасываем хук дальше
            return CallNextHookEx(_hHook, code, (int)wParam, lParam);

        }


    }
}
