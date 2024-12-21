using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_of_Classes
{
    internal class Point2D
    {
        private double x, y;

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public void Move(double dx, double dy)
        {
            x += dx;  y += dy;
        }

        public override string ToString()
        {
            return  "Point2D: " + "(" + x + ", " + y + ")" + ".";
        }

    }
}
