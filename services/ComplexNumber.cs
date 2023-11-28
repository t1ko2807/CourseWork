namespace TMath.services
{
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.Real + num2.Real, num1.Imaginary + num2.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.Real - num2.Real, num1.Imaginary - num2.Imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber num1, ComplexNumber num2)
        {
            double realPart = (num1.Real * num2.Real) - (num1.Imaginary * num2.Imaginary);
            double imaginaryPart = (num1.Real * num2.Imaginary) + (num1.Imaginary * num2.Real);
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public static ComplexNumber operator /(ComplexNumber num1, ComplexNumber num2)
        {
            double denominator = (num2.Real * num2.Real) + (num2.Imaginary * num2.Imaginary);
            double realPart = ((num1.Real * num2.Real) + (num1.Imaginary * num2.Imaginary)) / denominator;
            double imaginaryPart = ((num1.Imaginary * num2.Real) - (num1.Real * num2.Imaginary)) / denominator;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public double Modulus()
        {
            return Math.Sqrt(Real * Real + Imaginary * Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
