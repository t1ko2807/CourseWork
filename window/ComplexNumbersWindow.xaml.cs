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
using TMath.services;

namespace TMath
{
    /// <summary>
    /// Interaction logic for ComplexNumbersWindow.xaml
    /// </summary>
    public partial class ComplexNumbersWindow : Window
    {
        public ComplexNumbersWindow()
        {
            InitializeComponent();
        }

        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {
            CalculateAndDisplayResult((num1, num2) => num1 + num2);
        }

        private void OnSubtractButtonClick(object sender, RoutedEventArgs e)
        {
            CalculateAndDisplayResult((num1, num2) => num1 - num2);
        }

        private void OnMultiplyButtonClick(object sender, RoutedEventArgs e)
        {
            CalculateAndDisplayResult((num1, num2) => num1 * num2);
        }

        private void OnDivideButtonClick(object sender, RoutedEventArgs e)
        {
            CalculateAndDisplayResult((num1, num2) => num1 / num2);
        }

        private void CalculateAndDisplayResult(Func<ComplexNumber, ComplexNumber, ComplexNumber> operation)
        {
            double real1 = ParseTextBoxValue(real1TextBox.Text);
            double imaginary1 = ParseTextBoxValue(imaginary1TextBox.Text);
            double real2 = ParseTextBoxValue(real2TextBox.Text);
            double imaginary2 = ParseTextBoxValue(imaginary2TextBox.Text);

            ComplexNumber num1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber num2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber result = operation(num1, num2);

            resultTextBlock.Text = result.ToString();
        }

        private double ParseTextBoxValue(string text)
        {
            if (double.TryParse(text, out double result))
            {
                return result;
            }
            return 0;
        }
        private void OnModulusButtonClick(object sender, RoutedEventArgs e)
        {
            double real3 = ParseTextBoxValue(real1TextBox.Text);
            double imaginary3 = ParseTextBoxValue(imaginary1TextBox.Text);

            ComplexNumber num3 = new ComplexNumber(real3, imaginary3);

            double modulus = num3.Modulus();

            resultTextBlock.Text = $"Modulus: {modulus}";
        }
    }
}
