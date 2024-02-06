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
using System.Numerics;

namespace factorialLB1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void btn_Count_Click(object sender, RoutedEventArgs e)
        {
            ulong num = ulong.Parse(txt_Number.Text);
            ulong factorial = 1;
            if (num >= 0)
            {
                try
                {
                    for (ulong i = 1; i <= num; i++)
                    {
                        factorial *= i;
                    }
                    txt_Result.Text = factorial.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введенное число меньше нуля!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
                txt_Result.Text = "Ошибка";
            }
            
        }
    }
}
