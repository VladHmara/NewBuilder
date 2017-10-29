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
using NewBuilder.Common;




namespace Builder.Interface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    [ComVisibleAttribute(true)]
    /// 
    public partial class MainWindow : Window
    {

        Hook myHook = new Hook();

        public MainWindow()
        {
            InitializeComponent();

            //Controls.KeyUp += Controls_KeyUp;

            //Controls.KeyDown += Controls_KeyDown;
            //Hook myHook = new Hook();

            Bind.Load();
            BindContent.Load();
            if (Bind.Items.Count == 0)
                for (int i = 0; i < 10; i++)
                    new Bind() { Name = "name", Count = 4 };

            DataContext = new BindVM();
        }

        // переписать, на то же самое что и в Controls_KeyDown
        private void Controls_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key.Equals(Key.Back))
            {
                ((TextBox)sender).Text = "Нет";
            }
        }

        // Переписать весь метод, используя ModifierKeys
        private void Controls_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;


           // ((TextBox)sender).Text = myHook.BufferKeyList(); //нах это надо?

            if (((TextBox)sender).IsKeyboardFocused)
            {
                if (e.KeyboardDevice.Modifiers == ModifierKeys.None)
                {
                    //если это не сама клавиша shift | ctrl | Alt || System 
                    if (e.Key != Key.LeftShift && e.Key != Key.LeftCtrl && e.Key != Key.LeftAlt && e.Key != Key.System && e.Key != Key.RightShift && e.Key != Key.RightCtrl && e.Key != Key.RightAlt)
                        ((TextBox)sender).Text = e.Key.ToString();

                }
                else
                {
                    //если это не сама клавиша shift | ctrl | Alt || System c + Modifers
                    if (e.Key != Key.LeftShift && e.Key != Key.LeftCtrl && e.Key != Key.LeftAlt && e.Key != Key.System && e.Key != Key.RightShift && e.Key != Key.RightCtrl && e.Key != Key.RightAlt)
                        ((TextBox)sender).Text = e.KeyboardDevice.Modifiers.ToString().Replace(",", " + ") + " + " + e.Key.ToString();
                    else
                    {
                        ((TextBox)sender).Text = "Нет";
                    }
                }

                

            }
        }

        private void creatingNewCommands(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(((TextBox)((Button)sender).Tag).Text);
            Bind bind = (Bind)((Grid)((Button)sender).Parent).Tag;
            CreatingCommands instanceCreatingNewCommands = new CreatingCommands(bind, count);
            instanceCreatingNewCommands.Show();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Bind.Save();
            BindContent.Save();
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            ((BindVM)DataContext).SaveChange();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            SettingsForm instance = new SettingsForm()
            {
                Owner = this
            };
            instance.Show();
        }
    }
}

