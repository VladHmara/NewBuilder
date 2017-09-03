using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Runtime.InteropServices;




namespace Builder.Interface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    [ComVisibleAttribute(true)]
    /// 
    public partial class MainWindow : Window
    {
        private List<Key> bufferKeys = new List<Key>();
        private Hook _hook;

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        public MainWindow()
        {
            InitializeComponent();

            //Controls.KeyUp += Controls_KeyUp;

            //Controls.KeyDown += Controls_KeyDown;

            //keybd_event(0x46, 0x45, 0x1, (UIntPtr)0);

            //// 0x90 клавиша NumLock
            //_hook = new Hook(0x46); 

            //_hook.KeyPressed += new System.Windows.Forms.KeyPressEventHandler(_hook_KeyPressed);
            //_hook.SetHook();

            DataContext = new BindVM();

        }

        private void Controls_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key.Equals(Key.Back))
            {
                bufferKeys.Clear();
                ((TextBox)sender).Text = "Нет";
            }
            bufferKeys.Remove(e.Key);

        }

        private void Controls_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            if (((TextBox)sender).IsKeyboardFocused)
            {
                if (bufferKeys.Count > 0)
                {
                    if (bufferKeys.Last() != e.Key)
                    {
                        if (bufferKeys.Last() < Key.A || bufferKeys.Last() > Key.Z)
                        {
                            bufferKeys.Add(e.Key);
                        }
                        else
                        {
                            bufferKeys.Remove(bufferKeys.Last());
                            bufferKeys.Add(e.Key);
                        }
                    }
                }
                else
                {
                    bufferKeys.Add(e.Key);
                }
            }

             ((TextBox)sender).Text = String.Empty;

            foreach (var item in bufferKeys)
            {
                if (bufferKeys.IndexOf(item) != bufferKeys.Count - 1)
                    ((TextBox)sender).Text += item + " + ";

                else
                    ((TextBox)sender).Text += item;
            }

        }

        private void creatingNewCommands(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(((TextBox)((Button)sender).Tag).Text);

            CreatingCommands instance = new CreatingCommands(count);
            instance.Show();
        }

        void _hook_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e) //Событие нажатия клавиш
        {
            //DopText.Text = "Hi";
        }
    }
}

