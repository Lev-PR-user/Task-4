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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void CalculateSumButton_Click(object sender, RoutedEventArgs e)
        {
          
            if (int.TryParse(InputTextBox.Text, out int n) && n > 0)
            {
             
                int sum = (n * (n + 1)) / 2;

            
                ResultTextBlock.Text = $"Сумма от 1 до {n} = {sum}";
            }
            else
            {
                ResultTextBlock.Text = "Пожалуйста, введите положительное целое число.";
            }
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

    

