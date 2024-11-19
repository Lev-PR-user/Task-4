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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace задание4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void W1_Click(object sender, RoutedEventArgs e)
        {
            
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void W2_Click(object sender, RoutedEventArgs e)
        {
            Window window2 = new Window2();
            window2.Show();
        }

        private void W3_Click(object sender, RoutedEventArgs e)
        {
            Window window3 = new Window3();
            window3.Show();
        }

        private void W4_Click(object sender, RoutedEventArgs e)
        {
            Window window4 = new Window4();
            window4.Show();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
