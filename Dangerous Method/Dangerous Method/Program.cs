using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dangerous_Method
{
    // Dangerous program. 
    // M2 is virtual in A and overridden in B. 
    // Compiles and runs 
    // Default Java semantics.

    class A
    {
        public void M1()
        {
            Console.WriteLine("Method 1");
            this.M2();
        }

        public virtual void M2()
        {
            Console.WriteLine("M2 in a new Version of A");
        }
    }

    // New method in this version. 
    // Same name as the dangerous operation in subclass B

    class B : A 
    {
        public override void M2()
        {
            Console.WriteLine("Dangerous Method 2");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            B b = new B();

            a.M1(); // Nothing dangerous expected 
                    // Will, however, call the dangerous operation 
                    // because M2 is virtual.

            a.M2(); // Makes sense when M2 exists in class A. 
                    // Calls the dangerous method 

            b.M2(); // Calls the dangerous method. 
                    // This is expected, however.
        }
    }
}
