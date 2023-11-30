using System.Windows;
using TMath.services;

namespace MatrixSolverApp
{
    public partial class MatricesWindow : Window
    {
        public MatricesWindow()
        {
            InitializeComponent();
        }

        private double[,] GetMatrixFromInput()
        {
            try
            {
                string[] rows = MatrixInputTextBox.Text.Trim().Split('\n');
                int rowCount = rows.Length;
                int colCount = rows[0].Split(' ').Length;

                if (rowCount != colCount)
                {
                    MessageBox.Show($"Մատրիցայի վերլուծության սխալ. մատրից չի տրվել");
                    return new double[0, 0];
                }

                double[,] matrix = new double[rowCount, colCount];

                for (int i = 0; i < rowCount; i++)
                {
                    string[] values = rows[i].Split(' ');

                    for (int j = 0; j < colCount; j++)
                    {
                        matrix[i, j] = Convert.ToDouble(values[j]);
                    }
                }

                return matrix;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Մատրիցայի վերլուծության սխալ: {ex.Message}");
                return new double[0, 0];
            }
        }

        private void DisplayResult(double[,] resultMatrix)
        {
            if (resultMatrix != null)
            {
                ResultTextBox.Text = "";
                for (int i = 0; i < resultMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < resultMatrix.GetLength(1); j++)
                    {
                        ResultTextBox.Text += $"{resultMatrix[i, j]} ";
                    }
                    ResultTextBox.Text += "\n";
                }
            }
        }

        private void DisplayResult(Fraction[,] resultMatrix)
        {
            if (resultMatrix != null)
            {
                ResultTextBox.Text = "";
                for (int i = 0; i < resultMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < resultMatrix.GetLength(1); j++)
                    {
                        ResultTextBox.Text += $"{resultMatrix[i, j]} ";
                    }
                    ResultTextBox.Text += "\n";
                }
            }
        }

        private void DeterminantButton_Click(object sender, RoutedEventArgs e)
        {
            double[,] matrix = GetMatrixFromInput();
            if (matrix != null)
            {
                MatrixSolver solver = new MatrixSolver(matrix);
                double determinant = solver.CalculateDeterminant();
                ResultTextBox.Text = $"Որոշիչ: {determinant}";
            }
        }

        private void InverseButton_Click(object sender, RoutedEventArgs e)
        {
            double[,] matrix = GetMatrixFromInput();
            if (matrix != null)
            {
                MatrixSolver solver = new MatrixSolver(matrix);
                if (cofactorCheckbox.IsChecked == true)
                {
                    Fraction[,] inverseMatrix = solver.InverseFractional();
                    DisplayResult(inverseMatrix);

                }
                else
                {
                    double[,] inverseMatrix = solver.Inverse();
                    DisplayResult(inverseMatrix);
                }
            }            
        }

        private void TransposeButton_Click(object sender, RoutedEventArgs e)
        {
            double[,] matrix = GetMatrixFromInput();
            if (matrix != null)
            {
                MatrixSolver solver = new MatrixSolver(matrix);
                double[,] transposedMatrix = solver.Transpose();
                DisplayResult(transposedMatrix);
            }
        }

        private void ScalarMultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            double[,] matrix = GetMatrixFromInput();
            if (matrix != null)
            {
                string userInput = Microsoft.VisualBasic.Interaction.InputBox("Մուտքագրեք թվային արժեքը:", "Աստիճանի բարձրացում");

                if (double.TryParse(userInput, out double scalar))
                {
                    MatrixSolver solver = new MatrixSolver(matrix);
                    double[,] resultMatrix = solver.MultiplyByScalar(scalar);
                    DisplayResult(resultMatrix);
                }
                else
                {
                    MessageBox.Show("Սխալ տեղի ունեցավ: Խնդրում եմ մուտքագրեք ճշգրիտ թիվ։");
                }
            }
        }

        private void PowerButton_Click(object sender, RoutedEventArgs e)
        {
            double[,] matrix = GetMatrixFromInput();
            if (matrix != null)
            {
                string userInput = Microsoft.VisualBasic.Interaction.InputBox("Մուտքագրեք թվային արժեքը:", "Աստիճանի բարձրացում");

                if (int.TryParse(userInput, out int exponent))
                {
                    MatrixSolver solver = new MatrixSolver(matrix);
                    double[,] resultMatrix = solver.Power(exponent);
                    DisplayResult(resultMatrix);
                }
                else
                {
                    MessageBox.Show("Սխալ տեղի ունեցավ: Խնդրում եմ մուտքագրեք ճշգրիտ թիվ։");
                }
            }
        }
    }
}
