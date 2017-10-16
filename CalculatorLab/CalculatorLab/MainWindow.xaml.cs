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

namespace CalculatorLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ICalculator Calc = new CalculatorLogic();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateNumber()
        {
            Number.Text = Calc.NumberOnScreen;
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            Calc.TabNumber(0);
            UpdateNumber();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Calc.TabNumber(1);
            UpdateNumber();
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Calc.TabNumber(2);
            UpdateNumber();
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Calc.TabNumber(3);
            UpdateNumber();
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Calc.TabNumber(4);
            UpdateNumber();
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Calc.TabNumber(5);
            UpdateNumber();
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Calc.TabNumber(6);
            UpdateNumber();
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Calc.TabNumber(7);
            UpdateNumber();
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Calc.TabNumber(8);
            UpdateNumber();
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Calc.TabNumber(9);
            UpdateNumber();
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            Calc.DotActivate();
            UpdateNumber();
        }

        private void Equality_Click(object sender, RoutedEventArgs e)
        {
            Calc.Equality();
            UpdateNumber();
        }

        private void Summation_Click(object sender, RoutedEventArgs e)
        {
            Calc.Summation();
            UpdateNumber();
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            Calc.Subtraction();
            UpdateNumber();
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            Calc.Division();
            UpdateNumber();
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            Calc.Multiplication();
            UpdateNumber();
        }
    }
}
