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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //SEARCH
            Window4 objMenu = new Window4();
            this.Visibility = Visibility.Hidden;
            objMenu.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //NR
            Window3 objMenu = new Window3();
            this.Visibility = Visibility.Hidden;
            objMenu.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //BACK
            Window1 objMenu = new Window1();
            this.Visibility = Visibility.Hidden;
            objMenu.Show();
        }

      
    }
}
