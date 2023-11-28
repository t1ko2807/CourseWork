using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMath.services
{
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector FromPoints(Point point1, Point point2)
        {
            return new Vector(point2.X - point1.X, point2.Y - point1.Y, point2.Z - point1.Z);
        }

        public double Magnitude()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public void DirectionCosines(out double cosAlpha, out double cosBeta, out double cosGamma)
        {
            double magnitude = Magnitude();
            cosAlpha = X / magnitude;
            cosBeta = Y / magnitude;
            cosGamma = Z / magnitude;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector operator *(Vector v, double scalar)
        {
            return new Vector(v.X * scalar, v.Y * scalar, v.Z * scalar);
        }

        public static double DotProduct(Vector v1, Vector v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static double AngleBetween(Vector v1, Vector v2)
        {
            double dotProduct = DotProduct(v1, v2);
            double magnitudeProduct = v1.Magnitude() * v2.Magnitude();

            return Math.Acos(dotProduct / magnitudeProduct);
        }

        public static double Projection(Vector v1, Vector v2)
        {
            double dotProduct = DotProduct(v1, v2);
            double magnitudeSquared = v2.Magnitude();

            return dotProduct / magnitudeSquared;
        }

    }
}
