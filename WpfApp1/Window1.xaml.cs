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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //NEW RECIPE btn will take you to the recipe page
            Window3 objMenu = new Window3();
            this.Visibility = Visibility.Hidden;
            objMenu.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //VIEW RECIPE btn will take you to the view recipe page
            Window5 objMenu = new Window5();
            this.Visibility = Visibility.Hidden;
            objMenu.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //EDIT btn will take you to the recipe edit page
            Window2 objMenu = new Window2();
            this.Visibility = Visibility.Hidden;
            objMenu.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //SEARCH btn will take you to the search page
            Window4 objMenu = new Window4();
            this.Visibility = Visibility.Hidden;
            objMenu.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            // EXIT btn will close the application
            this.Close();
        }
    }
}
