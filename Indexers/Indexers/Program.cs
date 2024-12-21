using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //A a = new A(6);
            //double d;
            //Console.WriteLine(a);
            //a[1] = 6; a[2] = 7.0; a[3] = 8.0;

            ////a[4] = 1.2;

            //d = a[1] + a[2];

            //Console.WriteLine("a: {0}, d: {1}", a, d);

            B a = new B();
            double d;
            Console.WriteLine(a);
            a["d"] = 6; a["f"] = 7.0; a["e"] = 8.0;

            //a[4] = 1.2;

            d = a["d"] + a["f"];

            Console.WriteLine("a: {0}, d: {1}", a, d);


            // The compiler will complain if a local variable is referred without prior assignment
            //int x;
            //Console.WriteLine(x);


            //int s;
            //ouT(out s);
            //Console.WriteLine(s);
        }


        //public static void ouT(out int d)
        //{
        //    d = 0;
        //}
    }
}
