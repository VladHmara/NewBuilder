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
        private List<Key> bufferKeys = new List<Key>(); // буфер не нужен, удалить

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

        // Думать что написать
        private void Controls_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.Key.Equals(Key.Back))
            //{
            //    bufferKeys.Clear();
            //    ((TextBox)sender).Text = "Нет";
            //}
            //bufferKeys.Remove(e.Key);
        }

        // Написать используя... используя... хук, вот.
        private void Controls_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            if (((TextBox)sender).IsKeyboardFocused)
            {
                //e.KeyboardDevice.Modifiers
                //if (e.KeyboardDevice.Modifiers == (ModifierKeys.Control | ModifierKeys.Shift))

                if (bufferKeys.Count > 0)
                {
                    if (bufferKeys.Last() != e.Key)
                    {
                        //Нажата спецальная клавиша
                        if ((bufferKeys.Last() < Key.A || bufferKeys.Last() > Key.Z) && (bufferKeys.Last() < Key.D1 || bufferKeys.Last() > Key.D9))
                        {
                            bufferKeys.Add(e.Key);
                        }
                        else
                        //не специальная клавиша
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
            //((TextBox)sender).Text = string.Empty;
            //((TextBox)sender).Text += e.KeyboardDevice.Modifiers;
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

