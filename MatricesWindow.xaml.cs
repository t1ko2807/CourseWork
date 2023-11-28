﻿using System.Windows;
using TMath.services;
using System.Numerics;

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
                    MessageBox.Show($"Error parsing matrix: No matrix were given");
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
                MessageBox.Show($"Error parsing matrix: {ex.Message}");
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
                ResultTextBox.Text = $"Determinant: {determinant}";
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
                double scalar = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter scalar value:", "Scalar Multiply"));
                MatrixSolver solver = new MatrixSolver(matrix);
                double[,] resultMatrix = solver.MultiplyByScalar(scalar);
                DisplayResult(resultMatrix);
            }
        }

        private void PowerButton_Click(object sender, RoutedEventArgs e)
        {
            double[,] matrix = GetMatrixFromInput();
            if (matrix != null)
            {
                int exponent = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter exponent value:", "Matrix Power"));
                MatrixSolver solver = new MatrixSolver(matrix);
                double[,] resultMatrix = solver.Power(exponent);
                DisplayResult(resultMatrix);
            }
        }
    }
}
