using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Builder.Interface
{
    static class KeysCode
    {
        static Dictionary<String, int> myKey = new Dictionary<String, int>();
        
        private static void MyKeyAdding()
        {
            myKey.Add(Key.Back.ToString(), 0x8);
            myKey.Add(Key.Tab.ToString(), 0x9);
            myKey.Add(Key.Enter.ToString(), 0x0D);
            myKey.Add(Key.CapsLock.ToString(), 0x14);
            myKey.Add(Key.Escape.ToString(), 0x1B);
            myKey.Add(Key.PageUp.ToString(), 0x21);
            myKey.Add(Key.PageDown.ToString(), 0x22);
            myKey.Add(Key.End.ToString(), 0x23);
            myKey.Add(Key.Home.ToString(), 0x24);
            myKey.Add(Key.Left.ToString(), 0x25);
            myKey.Add(Key.Up.ToString(), 0x26);
            myKey.Add(Key.Right.ToString(), 0x27);
            myKey.Add(Key.Down.ToString(), 0x28);
            myKey.Add(Key.D0.ToString(), 0x30);
            myKey.Add(Key.D1.ToString(), 0x31);
            myKey.Add(Key.D2.ToString(), 0x32);
            myKey.Add(Key.D3.ToString(), 0x33);
            myKey.Add(Key.D4.ToString(), 0x34);
            myKey.Add(Key.D5.ToString(), 0x35);
            myKey.Add(Key.D6.ToString(), 0x36);
            myKey.Add(Key.D7.ToString(), 0x37);
            myKey.Add(Key.D8.ToString(), 0x38);
            myKey.Add(Key.D9.ToString(), 0x39);
            myKey.Add(Key.A.ToString(), 0x41);
            myKey.Add(Key.B.ToString(), 0x42);
            myKey.Add(Key.C.ToString(), 0x43);
            myKey.Add(Key.D.ToString(), 0x44);
            myKey.Add(Key.E.ToString(), 0x45);
            myKey.Add(Key.F.ToString(), 0x46);
            myKey.Add(Key.G.ToString(), 0x47);
            myKey.Add(Key.H.ToString(), 0x48);
            myKey.Add(Key.I.ToString(), 0x49);
            myKey.Add(Key.J.ToString(), 0x4A);
            myKey.Add(Key.K.ToString(), 0x4B);
            myKey.Add(Key.L.ToString(), 0x4C);
            myKey.Add(Key.M.ToString(), 0x4D);
            myKey.Add(Key.N.ToString(), 0x4E);
            myKey.Add(Key.O.ToString(), 0x4F);
            myKey.Add(Key.P.ToString(), 0x50);
            myKey.Add(Key.Q.ToString(), 0x51);
            myKey.Add(Key.R.ToString(), 0x52);
            myKey.Add(Key.S.ToString(), 0x53);
            myKey.Add(Key.T.ToString(), 0x54);
            myKey.Add(Key.U.ToString(), 0x55);
            myKey.Add(Key.V.ToString(), 0x56);
            myKey.Add(Key.W.ToString(), 0x57);
            myKey.Add(Key.X.ToString(), 0x58);
            myKey.Add(Key.Y.ToString(), 0x59);
            myKey.Add(Key.Z.ToString(), 0x5A);
            myKey.Add(Key.LWin.ToString(), 0x5B);
            myKey.Add(Key.RWin.ToString(), 0x5C);
            myKey.Add(Key.NumPad0.ToString(), 0x60);
            myKey.Add(Key.NumPad1.ToString(), 0x61);
            myKey.Add(Key.NumPad2.ToString(), 0x62);
            myKey.Add(Key.NumPad3.ToString(), 0x63);
            myKey.Add(Key.NumPad4.ToString(), 0x64);
            myKey.Add(Key.NumPad5.ToString(), 0x65);
            myKey.Add(Key.NumPad6.ToString(), 0x66);
            myKey.Add(Key.NumPad7.ToString(), 0x67);
            myKey.Add(Key.NumPad8.ToString(), 0x68);
            myKey.Add(Key.NumPad9.ToString(), 0x69);
            myKey.Add(Key.F1.ToString(), 0x70);
            myKey.Add(Key.F2.ToString(), 0x71);
            myKey.Add(Key.F3.ToString(), 0x72);
            myKey.Add(Key.F4.ToString(), 0x73);
            myKey.Add(Key.F5.ToString(), 0x74);
            myKey.Add(Key.F6.ToString(), 0x75);
            myKey.Add(Key.F7.ToString(), 0x76);
            myKey.Add(Key.F8.ToString(), 0x77);
            myKey.Add(Key.F9.ToString(), 0x78);
            myKey.Add(Key.F10.ToString(), 0x79);
            myKey.Add(Key.F11.ToString(), 0x9);
            myKey.Add(Key.F12.ToString(), 0x9);
            myKey.Add(Key.LeftShift.ToString(), 0x10);
            myKey.Add(Key.RightShift.ToString(), 0x10);
            myKey.Add(Key.LeftCtrl.ToString(), 0x11);
            myKey.Add(Key.RightCtrl.ToString(), 0x11);
            myKey.Add(Key.LeftAlt.ToString(), 0x12);
            myKey.Add(Key.RightAlt.ToString(), 0x12);
            







        }

    }
}
