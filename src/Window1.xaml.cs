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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (int.TryParse(AInput.Text, out int A) && int.TryParse(BInput.Text, out int B))
            {
                if (A < B)
                {
                  
                    int sum = 0;
                    StringBuilder oddNumbers = new StringBuilder();

                    for (int i = A + 1; i < B; i++)
                    {
                        sum += i; 

                        if (i % 2 != 0) 
                        {
                            oddNumbers.Append(i + " ");
                        }
                    }

                    // Выводим результаты
                    ResultTextBlock.Text = $"Сумма чисел между {A} и {B}: {sum}\nНечетные числа: {oddNumbers.ToString().Trim()}";
                }
                else
                {
                    MessageBox.Show("Ошибка: A должно быть меньше B.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Введите корректные целые числа.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}