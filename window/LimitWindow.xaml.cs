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
                resultLabel.Content = $"Արդյունք: {result}";
            }
            catch (ParseException)
            {
                MessageBox.Show("Որոշ դաշտեր սխալ են: Այս սխալը կանխելու համար օգտագործեք C# սինտաքսը");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Անսպասելի սխալ տեղի ունեցավ: {ex.Message}");
            }
        }
    }
}
