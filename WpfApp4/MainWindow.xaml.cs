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

namespace WpfApp4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rate0.Text);
            double sum = Convert.ToDouble(sum0.Text);
            double result = rate * sum;
            resSum0.Text = result.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rate1.Text);
            double sum = Convert.ToDouble(sum1.Text);
            double res = rate * sum;
            resSum1.Text = res.ToString();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rate2.Text);
            double sum = Convert.ToDouble(sum2.Text);
            double res = rate * sum;
            resSum2.Text = res.ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rate3.Text);
            double sum = Convert.ToDouble(sum3.Text);
            double res = rate * sum;
            resSum3.Text = res.ToString();
        }

        private void buttonLenght0_Click(object sender, RoutedEventArgs e)
        {
            double lenght = Convert.ToDouble(lenght0.Text);
            double result = lenght / 39.37;
            res0.Text = result.ToString();
        }

        private void buttonLenght1_Click(object sender, RoutedEventArgs e)
        {
            double lenght = Convert.ToDouble(lenght0.Text);
            double result = lenght / 3.281;
            res1.Text = result.ToString();
        }

        private void buttonLenght2_Click(object sender, RoutedEventArgs e)
        {
            double lenght = Convert.ToDouble(lenght0.Text);
            double result = lenght * 1609.34;
            res2.Text = result.ToString();
        }

        private void buttonLenght3_Click(object sender, RoutedEventArgs e)
        {
            double lenght = Convert.ToDouble(lenght3.Text);
            double result = lenght / 1.094;
            res3.Text = result.ToString();
        }
    }
}
