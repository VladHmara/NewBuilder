using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using NewBuilder.Common;


namespace Builder.Interface
{
    /// <summary>
    /// Логика взаимодействия для SettingsForm.xaml
    /// </summary>
    public partial class SettingsForm : Window
    {
        public SettingsForm()
        {
            InitializeComponent();

            foreach (var item in Bind.Items)
            {
                KeyStartChat.Text = item.KeyStartChat;
            }
        }

        private void Controls_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            if (((TextBox)sender).IsKeyboardFocused)
            {
                if (e.KeyboardDevice.Modifiers == ModifierKeys.None)
                {
                    ((TextBox)sender).Text = e.Key.ToString();

                }
            }
        }

        private void Controls_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key.Equals(Key.Back))
            {
                ((TextBox)sender).Text = "Y";
            }
        }

        private void BtnApply_Settings_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in Bind.Items)
            {
                item.KeyStartChat = KeyStartChat.Text;
            }

        }

        private void BtnSave_Settings_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
