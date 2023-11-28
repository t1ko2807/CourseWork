namespace TMath.services
{
    public class MatrixSolver
    {
        private double[,] matrix;
        private int matrixDimension;

        public MatrixSolver(double[,] matrix)
        {
            this.matrix = matrix;
            this.matrixDimension = matrix.GetLength(0);
        }

        public double CalculateDeterminant()
        {
            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new InvalidOperationException("Որոշիչը սահմանվում է միայն քառակուսի մատրիցների համար");
            }

            if (matrixDimension == 1)
            {
                return matrix[0, 0];
            }

            if (matrixDimension == 2)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }

            double determinant = 0;

            for (int i = 0; i < matrixDimension; i++)
            {
                determinant += matrix[0, i] * Cofactor(0, i) * Math.Pow(-1, i);
            }

            return determinant;
        }

        private double[,] Submatrix(int rowToRemove, int colToRemove)
        {
            double[,] submatrix = new double[matrixDimension - 1, matrixDimension - 1];

            int rowIndex = 0;
            for (int i = 0; i < matrixDimension; i++)
            {
                if (i == rowToRemove)
                    continue;

                int colIndex = 0;
                for (int j = 0; j < matrixDimension; j++)
                {
                    if (j == colToRemove)
                        continue;

                    submatrix[rowIndex, colIndex] = matrix[i, j];
                    colIndex++;
                }

                rowIndex++;
            }

            return submatrix;
        }

        private double Cofactor(int row, int col)
        {
            double[,] submatrix = Submatrix(row, col);
            MatrixSolver submatrixSolver = new MatrixSolver(submatrix);
            double cofactor = submatrixSolver.CalculateDeterminant();
            return cofactor;
        }
        public Fraction[,] InverseFractional()
        {
            Fraction determinant = new Fraction(Convert.ToInt32(CalculateDeterminant()), 1);

            if (determinant.Numerator == 0)
            {
                throw new InvalidOperationException("Հակադարձ մատրիցա չկա, քանի որ որոշիչը հավասար է 0-ի");
            }

            Fraction[,] inverseMatrix = new Fraction[matrixDimension, matrixDimension];

            for (int i = 0; i < matrixDimension; i++)
            {
                for (int j = 0; j < matrixDimension; j++)
                {
                    Fraction cofactor = new Fraction(Convert.ToInt32(Cofactor(i, j)), 1);
                    inverseMatrix[j, i] = cofactor * ((i + j) % 2 == 0 ? 1 : -1) / determinant;
                }
            }

            return inverseMatrix;
        }

        public double[,] Inverse()
        {
            double determinant = CalculateDeterminant();

            if (determinant == 0)
            {
                throw new InvalidOperationException("Հակադարձ մատրիցա չկա, քանի որ որոշիչը հավասար է 0-ի");
            }

            double[,] inverseMatrix = new double[matrixDimension, matrixDimension];

            for (int i = 0; i < matrixDimension; i++)
            {
                for (int j = 0; j < matrixDimension; j++)
                {
                    double cofactor = Cofactor(i, j);
                    inverseMatrix[j, i] = cofactor * ((i + j) % 2 == 0 ? 1 : -1) / determinant;
                }
            }

            return inverseMatrix;
        }

        public double[,] Transpose()
        {
            double[,] transposedMatrix = new double[matrixDimension, matrixDimension];

            for (int i = 0; i < matrixDimension; i++)
            {
                for (int j = 0; j < matrixDimension; j++)
                {
                    transposedMatrix[i, j] = matrix[j, i];
                }
            }

            return transposedMatrix;
        }
        public double[,] MultiplyByScalar(double scalar)
        {
            double[,] result = new double[matrixDimension, matrixDimension];

            for (int i = 0; i < matrixDimension; i++)
            {
                for (int j = 0; j < matrixDimension; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }

            return result;
        }

        public double[,] Power(int exponent)
        {
            if (exponent < 0)
            {
                throw new ArgumentException("Ցուցանիշը պետք է լինի ոչ բացասական");
            }

            if (exponent == 0)
            {
                return IdentityMatrix();
            }

            double[,] result = CopyMatrix(matrix);

            for (int i = 1; i < exponent; i++)
            {
                result = MatrixMultiply(result, matrix);
            }

            return result;
        }

        private double[,] IdentityMatrix()
        {
            double[,] identity = new double[matrixDimension, matrixDimension];

            for (int i = 0; i < matrixDimension; i++)
            {
                for (int j = 0; j < matrixDimension; j++)
                {
                    identity[i, j] = (i == j) ? 1 : 0;
                }
            }

            return identity;
        }

        private double[,] CopyMatrix(double[,] source)
        {
            double[,] copy = new double[matrixDimension, matrixDimension];

            for (int i = 0; i < matrixDimension; i++)
            {
                for (int j = 0; j < matrixDimension; j++)
                {
                    copy[i, j] = source[i, j];
                }
            }

            return copy;
        }
        private double[,] MatrixMultiply(double[,] a, double[,] b)
        {
            double[,] result = new double[matrixDimension, matrixDimension];

            for (int i = 0; i < matrixDimension; i++)
            {
                for (int j = 0; j < matrixDimension; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < matrixDimension; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return result;
        }
    }
}
