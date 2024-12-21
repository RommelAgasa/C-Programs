using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initialization_of_Class_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach (Card c in Card.allSpades)
            //    Console.WriteLine(c);

            int i = 5,
                j = 5;

            object m = 5,
            n = 5;

            Console.WriteLine(i == j); // True
            Console.WriteLine(m == n); // False
        }
    }
}
