using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_And_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 15, j, k;


            bool b = false, c, d;

            Object obj1 = 1,    // boxing of the value of i
                   obj2 = b;    // boxing of the value of b

            j = (int)obj1;  //unboxing obj1
            c = (bool)obj2;  //unboxing obj2


            // Compilation Error
            //k = i + obj1;
            //d = b && obj2;

            k = i + (int)obj1;
            d = b && (bool)obj2;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",
                                i, obj1, b, obj2, j, c, k, d);
        }
    }
}
