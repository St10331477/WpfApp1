using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //VIEW btn will take you the view repice page
            Window5 objMenu = new Window5();
            this.Visibility = Visibility.Hidden;
            objMenu.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //NEW btn will take you the recipe creation page
            Window3 objMenu = new Window3();
            this.Visibility = Visibility.Hidden;
            objMenu.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //SEARCH btn will take you the search page
            Window4 objMenu = new Window4();
            this.Visibility = Visibility.Hidden;
            objMenu.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //EXIT btn will close application
            this.Close();
        }
    }
}