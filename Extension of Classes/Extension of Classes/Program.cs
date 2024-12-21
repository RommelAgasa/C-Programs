using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_of_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point2D p1 = new Point2D(1.1, 2.2),
                    p2 = new Point2D(3.3, 4.4);

            Point3D q1 = new Point3D(1.1, 2.2, 3.3),
                    q2 = new Point3D(4.4, 5.5, 6.6);

            p2.Move(1.0, 2.0);
            q1.Move(1.0, 2.0, 3.0);
            Console.WriteLine("{0} {1}", p1, p2);
            Console.WriteLine("{0} {1}", q1, q2);

            /*
             * The important observations about the extension Point3D of Point2D can be stated as follows:
               • A 3D point is not a 2D point 
               • Thus, Point3D is not a specialization of Point2D
               • The principle of substitution does not apply 
               • The set of 2D point objects is disjoint from the set of 3D points
            */


            // ------------------------------------------------------

        }
    }
}


