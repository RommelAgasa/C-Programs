using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_of_Classes
{
    internal class Point3D : Point2D
    {
        private double z;

        public Point3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }

        public double Z { get { return z; } }

        public void Move(double dx, double dy, double dz)
        {
            base.Move(dx, dy);
            z += dz;
        }

        public override string ToString()
        {
            return "Point3D: " + "(" + X + ", " + Y + ", " + Z + ")" + ".";
        }
    }
}
