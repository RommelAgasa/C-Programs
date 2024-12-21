using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Point_Better_Solution
    {
        public enum PointRepresentation { Polar, Rectangular }

        private double r, a; // polar data repr: radius, angle

        //Construct a point with polar coordinates
        public Point_Better_Solution(double r, double a)
        {
            this.r = r;
            this.a = a;
        }

        public static Point_Better_Solution MakePolarPoint(double r, double a)
        {
            return new Point_Better_Solution(r, a);
        }

        public static Point_Better_Solution MakeRectanglePoint(double x, double y)
        {
            return new Point_Better_Solution(RadiusGivenXy(x, y), AngleGivenXy(x, y));
        }

        private static double RadiusGivenXy(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        private static double AngleGivenXy(double x, double y)
        {
            return Math.Atan2(x, y);
        }
    }
}
