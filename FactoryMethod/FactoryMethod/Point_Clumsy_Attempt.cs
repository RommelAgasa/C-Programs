using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Point_Clumsy_Attempt
    {
        public enum PointRepresentation { Polar, Rectangular}
        private double r, a; // polar data repr: radius, angle

        //Construct a point with polar coordinates
        public Point_Clumsy_Attempt(double r, double a)
        {
            this.r = r;
            this.a = a;
        }

        // Construct a point, the representation of whic depends
        // on the third parameter
        public Point_Clumsy_Attempt(double par1, double par2, PointRepresentation pr)
        {
            
            if(pr == PointRepresentation.Polar)
            {
                r = par1;
                a = par2;
            }
            else
            {
                r = RadiusGivenXy(par1, par2);
                a = AngleGivenXy(par1, par2);
            }
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
