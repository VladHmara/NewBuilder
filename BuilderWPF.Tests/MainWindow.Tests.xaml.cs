using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BuilderWPF.Tests
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Hook _hook;

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, byte bDop, uint dwFlags, UIntPtr dwExtraInfo);


        public MainWindow()
        {
            InitializeComponent();


            keybd_event(0x46, 0x45, 0x11,  0x1, (UIntPtr)0);

            //// 0x90 клавиша NumLock
            _hook = new Hook(0x46);

            _hook.KeyPressed += new System.Windows.Forms.KeyPressEventHandler(_hook_KeyPressed);
            _hook.SetHook();

        }

        void _hook_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e) //Событие нажатия клавиш
        {
            //DopText.Text = "Hi";


        }

    }
}
