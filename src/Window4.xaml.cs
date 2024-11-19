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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void CalculateBonus_Click(object sender, RoutedEventArgs e)
        {
        
            if (decimal.TryParse(SalaryTextBox.Text, out decimal salary) &&
                int.TryParse(YearsTextBox.Text, out int yearsOfService))
            {
               
                decimal bonusPercentage = CalculateBonusPercentage(yearsOfService);
                decimal bonus = salary * bonusPercentage;

                
                ResultTextBlock.Text = $"Ваша премия составляет: {bonus:C} ({bonusPercentage * 100}%)";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения.");
            }
        }

        private decimal CalculateBonusPercentage(int years)
        {
            if (years < 5)
                return 0.10m; 
            else if (years < 10)
                return 0.15m; 
            else if (years < 15)
                return 0.25m; 
            else if (years < 20)
                return 0.35m; 
            else if (years < 25)
                return 0.45m; 
            else
                return 0.50m; 
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
