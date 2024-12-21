using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passing_Structs_As_Value_Parameters
{
    internal class Program
    {

        public struct A
        {
            public int a;
            public int b;

            public override string ToString()
            {
                return "a = " + a + ", b = " + b; 
            }

        }
        static void Main(string[] args)
        {
            A a = new A();

            Console.WriteLine(a);
            change(a);
            Console.WriteLine(a);
        }

        public static void change(A c)
        {
            c.a = 1;
            c.b = 2;
        }
    }
}
