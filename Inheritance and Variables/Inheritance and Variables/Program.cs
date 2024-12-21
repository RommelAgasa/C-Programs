using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Variables
{

    class A
    {
        public int v = 1;
    }

    class B : A
    {
        public new int v = 5;
    }
    internal class Program
    {
        static void Main(string[] args)         // Static Type         Dynamic Type
        {
            A anA = new A(),                    // A                   A
              anotherA = new B();               // A                   B
            B aB = new B();                     // B                   B

            Console.WriteLine(
                    "{0}",
                    anA.v           // 1 
                  + anotherA.v      // 1 
                  + ((B)anotherA).v // 5 
                  + aB.v            // 5 
            );
        }
    }
}
