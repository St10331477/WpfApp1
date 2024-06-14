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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //BACK btn will take you home screen
            Window1 objMenu = new Window1();
            this.Visibility = Visibility.Hidden;
            objMenu.Show();
        }

    private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //rest
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //edit
            Window2 objMenu = new Window2();
            this.Visibility = Visibility.Hidden;
            objMenu.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //save
        }

    }
}
