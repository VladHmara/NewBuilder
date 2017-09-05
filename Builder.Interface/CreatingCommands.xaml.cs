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


        public CreatingCommands(int count)
        {
            InitializeComponent();

            //Title1.Height = 120;


            //Grid1.ColumnDefinitions.Add(new ColumnDefinition());
            //Grid1.ColumnDefinitions.Add(new ColumnDefinition());
            //Grid1.RowDefinitions.Add(new RowDefinition());

            //Grid1.RowDefinitions[0].Height = new GridLength(40);


            //Grid1.ColumnDefinitions[1].Width = GridLength.Auto;


            //Label lblHeader = new Label();
            //Label lblEnter = new Label();

            //lblHeader.Content = "Build";
            //lblEnter.Content = "Enter";


            //Grid.SetColumn(lblHeader, 0);
            //Grid.SetRow(lblHeader, 0);
            //Grid.SetColumn(lblEnter, 1);
            //Grid.SetRow(lblEnter, 0);

            //Grid1.Children.Add(lblHeader);
            //Grid1.Children.Add(lblEnter);


            //for (int i = 1; i < count * 2 + 1; i++)
            //{
            //    TextBox txtBox = new TextBox();
            //    TextBox txtBox2 = new TextBox();
            //    CheckBox chkBox1 = new CheckBox();
            //    Label lblDelay = new Label();

            //    Grid1.RowDefinitions.Add(new RowDefinition());
            //    Grid1.RowDefinitions[i].Height = new GridLength(30);


            //    txtBox.Margin = new Thickness { Top = 10, Right = 10, Left = 15 };
            //    chkBox1.Margin = new Thickness { Top = 10, Right = 15 };
            //    lblDelay.Margin = new Thickness { Top = 10, Right = 10, Left = 15 };
            //    txtBox2.Margin = new Thickness { Top = 10, Right = 15, };


            //    txtBox.Text = "Text";
            //    lblDelay.Content = "Delay";

            //    txtBox.HorizontalAlignment = HorizontalAlignment.Stretch;
            //    chkBox1.HorizontalAlignment = HorizontalAlignment.Right;
            //    lblDelay.HorizontalAlignment = HorizontalAlignment.Left;
            //    txtBox2.HorizontalAlignment = HorizontalAlignment.Stretch;
            //    lblDelay.Padding = new Thickness(0);
            //    lblDelay.VerticalAlignment = VerticalAlignment.Top;


            //    txtBox2.Height = 20;
            //    txtBox2.Width = 70;



            //    Grid.SetColumn(txtBox, 0);
            //    Grid.SetRow(txtBox, i);

            //    Grid.SetColumn(chkBox1, 1);
            //    Grid.SetRow(chkBox1, i);

            //    Grid1.Children.Add(txtBox);
            //    Grid1.Children.Add(chkBox1);

            //    i = i + 1;

            //    Grid1.RowDefinitions.Add(new RowDefinition());
            //    Grid1.RowDefinitions[i].Height = new GridLength(40);


            //    Grid.SetColumn(lblDelay, 0);
            //    Grid.SetRow(lblDelay, i);

            //    Grid.SetColumn(txtBox2, 0);
            //    Grid.SetRow(txtBox2, i);




            //    Grid1.Children.Add(lblDelay);
            //    Grid1.Children.Add(txtBox2);



            //    Title1.Height += 70;

        }
    }

}
