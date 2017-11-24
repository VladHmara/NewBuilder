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
        public Hook myHook = new Hook();

        public MainWindow()
        {
            InitializeComponent();

            //Controls.KeyUp += Controls_KeyUp;

            //Controls.KeyDown += Controls_KeyDown;
            //Hook myHook = new Hook();

            Bind.Load();
            BindContent.Load();
            if (Bind.Items.Count == 0)
                for (int i = 0; i < 100; i++)
                    new Bind();

            DataContext = new TabVM();
        }

        private void TextBox_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (((TextBox)sender).Text.Length > 1 && ((TextBox)sender).Text[((TextBox)sender).Text.Length - 2] == '+')
                ((TextBox)sender).Text = "Нет";
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.Key.Equals(Key.Back))
            {
                ((TextBox)sender).Text = "Нет";
            }
            else
            {
                switch (e.KeyboardDevice.Modifiers)
                {
                    case 0:
                        ((TextBox)sender).Text = e.Key.ToString();
                        break;
                    case (ModifierKeys)5:
                    case (ModifierKeys)1:
                        if (e.SystemKey == Key.LeftAlt || e.SystemKey == Key.RightAlt)
                            ((TextBox)sender).Text = e.KeyboardDevice.Modifiers.ToString().Replace(",", " +") + " + ";
                        else
                            ((TextBox)sender).Text = e.KeyboardDevice.Modifiers.ToString().Replace(",", " +") + " + " + e.SystemKey.ToString();
                        break;
                    default:
                        if (e.Key == Key.LeftAlt || e.Key == Key.LeftCtrl || e.Key == Key.LeftShift || 
                            e.Key == Key.RightAlt || e.Key == Key.RightCtrl || e.Key == Key.RightShift)
                            ((TextBox)sender).Text = e.KeyboardDevice.Modifiers.ToString().Replace(",", " +") + " + ";
                        else
                            ((TextBox)sender).Text = e.KeyboardDevice.Modifiers.ToString().Replace(",", " +") + " + " + e.Key.ToString();
                        break;
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
            ((TabVM)DataContext).SaveChange();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            SettingsForm instance = new SettingsForm()
            {
                Owner = this
            };
            instance.Show();
        }
        //********************************/
        /************For Menu ************/
        //********************************/


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void NewProfile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OpenProfile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Donation_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}

