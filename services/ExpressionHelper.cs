
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace TMath.services
{
    static class ExpressionHelper
    {
        public static Func<double, double> CreateFunction(string expressionString)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(double), "x");
            LambdaExpression lambda = DynamicExpressionParser.ParseLambda(new[] { parameter }, null, expressionString);
            return (Func<double, double>)lambda.Compile();
        }
    }
}
