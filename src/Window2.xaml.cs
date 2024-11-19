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

namespace задание4
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void ShowSquaresButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder squares = new StringBuilder();

        
            for (int i = 10; i <= 20; i++)
            {
                squares.AppendLine($"Квадрат числа {i} = {i * i}");
            }

        
            ResultTextBlock.Text = squares.ToString();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
    

