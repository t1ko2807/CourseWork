using MatrixSolverApp;
using System.Windows;

namespace TMath
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComplexNumbers_Click(object sender, RoutedEventArgs e)
        {
            ComplexNumbersWindow complexNumbersWindow = new ComplexNumbersWindow();
            complexNumbersWindow.Show();
        }

        private void Matrices_Click(object sender, RoutedEventArgs e)
        {
            MatricesWindow matricesWindow = new MatricesWindow();
            matricesWindow.Show();
        }

        private void Vectors_Click(object sender, RoutedEventArgs e)
        {
            VectorsWindow vectorsWindow = new VectorsWindow();
            vectorsWindow.Show();
        }

        private void Limit_Click(object sender, RoutedEventArgs e)
        {
            LimitWindow limitWindow = new LimitWindow();
            limitWindow.Show();
        }
    }
}
