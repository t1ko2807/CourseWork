using System.Linq.Expressions;

namespace TMath.services
{
    public class LimitSolver
    {
        private Func<double, double> function;
        private double? limit;

        public LimitSolver(Func<double, double> function)
        {
            this.function = function;
            this.limit = null;
        }

        public LimitSolver(Func<double, double> function, double limit)
        {
            this.function = function;
            this.limit = limit;
        }

        public double CalculateLimit()
        {
            const double epsilon = 1e-16;

            if (limit.HasValue)
            {
                double result = function(limit.Value);

                for (int i = 0; i < 1000; i++)
                {
                    double deltaX = 1.0 / Math.Pow(2, i);
                    double nextResult = function(limit.Value + deltaX);

                    if (Math.Abs(nextResult - result) < epsilon)
                    {
                        result = nextResult;
                        break;
                    }

                    result = nextResult;
                }

                return result;
            }
            else
            {
                return CalculateLimitToInfinity();
            }
        }

        private double CalculateLimitToInfinity()
        {
            Expression<Func<double, double>> expression = x => function(x);
            int n = 0;
            double Sn = 0, Sn1 = 0.1;

            while (Math.Abs(Sn1 - Sn) > 10e-6)
            {
                n++;
                Sn = Sn1;
                Sn1 = expression.Compile()(n);

            }
            return Sn1;
        }
    }
}
