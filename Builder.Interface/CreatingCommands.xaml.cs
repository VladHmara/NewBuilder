using NewBuilder.Common;
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

namespace Builder.Interface
{
    /// <summary>
    /// Логика взаимодействия для CreatingCommands.xaml
    /// </summary>
    public partial class CreatingCommands : Window
    {


        public CreatingCommands(Bind bind,int count)
        {
            InitializeComponent();

            DataContext = new BindContentVM(bind, count);
        }

        private void btnSaveClick(object sender, RoutedEventArgs e)
        {
            ((BindContentVM)DataContext).SaveChange();
            Close();
        }
    }

}
