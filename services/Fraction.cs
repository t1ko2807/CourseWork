namespace TMath.services
{
    public class Fraction
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Հայտարարը չի կարող զրո լինել");

            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            Numerator = numerator / gcd;
            Denominator = denominator / gcd;

            if (Denominator < 0 && Numerator < 0)
            {
                Numerator = Math.Abs(Numerator);
                Denominator = Math.Abs(Denominator);
            }
            else if (Denominator < 0 || Numerator < 0)
            {
                Numerator = -Math.Abs(Numerator);
                Denominator = Math.Abs(Denominator);
            }
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;

            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;

            return new Fraction(numerator, denominator);
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator > b.Numerator * a.Denominator;
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator < b.Numerator * a.Denominator;
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Numerator == 0)
                throw new DivideByZeroException("Հնարավոր չէ բաժանել զրոյի");

            return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }

        public static Fraction operator *(Fraction a, int scalar)
        {
            return new Fraction(a.Numerator * scalar, a.Denominator);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}