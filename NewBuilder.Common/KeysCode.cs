using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBuilder.Common
{
    public static class KeysCode
    {
        public static Dictionary<string, int> myKey1 = new Dictionary<string, int>();
        public static Dictionary<int, string> myKey2 = new Dictionary<int, string>();

        static KeysCode()
        {
            myKey1.Add("Back", 0x8);
            myKey1.Add("Tab", 0x9);
            myKey1.Add("Enter", 0x0D);
            myKey1.Add("CapsLock", 0x14);
            myKey1.Add("Escape", 0x1B);
            myKey1.Add("PageUp", 0x21);
            myKey1.Add("PageDown", 0x22);
            myKey1.Add("End", 0x23);
            myKey1.Add("Home", 0x24);
            myKey1.Add("Left", 0x25);
            myKey1.Add("Up", 0x26);
            myKey1.Add("Right", 0x27);
            myKey1.Add("Down", 0x28);
            myKey1.Add("D0", 0x30);
            myKey1.Add("D1", 0x31);
            myKey1.Add("D2", 0x32);
            myKey1.Add("D3", 0x33);
            myKey1.Add("D4", 0x34);
            myKey1.Add("D5", 0x35);
            myKey1.Add("D6", 0x36);
            myKey1.Add("D7", 0x37);
            myKey1.Add("D8", 0x38);
            myKey1.Add("D9", 0x39);
            myKey1.Add("A", 0x41);
            myKey1.Add("B", 0x42);
            myKey1.Add("C", 0x43);
            myKey1.Add("D", 0x44);
            myKey1.Add("E", 0x45);
            myKey1.Add("F", 0x46);
            myKey1.Add("G", 0x47);
            myKey1.Add("H", 0x48);
            myKey1.Add("I", 0x49);
            myKey1.Add("J", 0x4A);
            myKey1.Add("K", 0x4B);
            myKey1.Add("L", 0x4C);
            myKey1.Add("M", 0x4D);
            myKey1.Add("N", 0x4E);
            myKey1.Add("O", 0x4F);
            myKey1.Add("P", 0x50);
            myKey1.Add("Q", 0x51);
            myKey1.Add("R", 0x52);
            myKey1.Add("S", 0x53);
            myKey1.Add("T", 0x54);
            myKey1.Add("U", 0x55);
            myKey1.Add("V", 0x56);
            myKey1.Add("W", 0x57);
            myKey1.Add("X", 0x58);
            myKey1.Add("Y", 0x59);
            myKey1.Add("Z", 0x5A);
            myKey1.Add("LWin", 0x5B);
            myKey1.Add("RWin", 0x5C);
            myKey1.Add("NumPad0", 0x60);
            myKey1.Add("NumPad1", 0x61);
            myKey1.Add("NumPad2", 0x62);
            myKey1.Add("NumPad3", 0x63);
            myKey1.Add("NumPad4", 0x64);
            myKey1.Add("NumPad5", 0x65);
            myKey1.Add("NumPad6", 0x66);
            myKey1.Add("NumPad7", 0x67);
            myKey1.Add("NumPad8", 0x68);
            myKey1.Add("NumPad9", 0x69);
            myKey1.Add("F1", 0x70);
            myKey1.Add("F2", 0x71);
            myKey1.Add("F3", 0x72);
            myKey1.Add("F4", 0x73);
            myKey1.Add("F5", 0x74);
            myKey1.Add("F6", 0x75);
            myKey1.Add("F7", 0x76);
            myKey1.Add("F8", 0x77);
            myKey1.Add("F9", 0x78);
            myKey1.Add("F10", 0x79);
            //myKey1.Add("F11", 0x9);
            //myKey1.Add("F12", 0x9);
            //myKey1.Add("LeftShift", 0x10);
            //myKey1.Add("RightShift", 0x10);
            //myKey1.Add("LeftCtrl", 0x11);
            //myKey1.Add("RightCtrl", 0x11);
            //myKey1.Add("LeftAlt", 0x12);
            //myKey1.Add("RightAlt", 0x12);

            foreach (string key in myKey1.Keys)
                myKey2.Add(myKey1[key], key);

        }

        public static List<int> StringToList(string keys)
        {
            List<int> li = new List<int>();
            foreach (string key in keys.Trim(' ').Split('+'))
                li.Add(myKey1[key]);
            return li;
        }
        public static string ListToString(List<int> keys)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int key in keys)
                if (keys.IndexOf(key) != keys.Count - 1)
                    sb.AppendFormat("{0} +", myKey2[key]);
                else
                    sb.Append(myKey2[key]);
            return sb.ToString();
        }
    }
}
