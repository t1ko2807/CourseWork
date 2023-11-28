using TMath.services;
using System.Windows;
using System.Linq.Dynamic.Core.Exceptions;

namespace TMath
{
    public partial class LimitWindow : Window
    {
        public LimitWindow()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            LimitSolver limit;
            string functionText = functionTextBox.Text;
            string limitText = limitTextBox.Text;
            try
            {
                Func<double, double> function = ExpressionHelper.CreateFunction(functionText);
                if (limitText == "inf" || limitText.Length == 0)
                {
                    limit = new LimitSolver(function);
                }
                else
                {
                    int limitTo = Convert.ToInt32(limitText);
                    limit = new LimitSolver(function, limitTo);
                }
                double result = limit.CalculateLimit();
                resultLabel.Content = $"Result: {result}";
            }
            catch (ParseException)
            {
                MessageBox.Show($"Some argumets are wrong. Use C# syntax to prevent this error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
