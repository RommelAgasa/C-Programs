using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Visibility_and_Inheritance
{

    public class A
    {
        private int i = 7;

        protected int F(int j) { return i + j; }
    }


    public class B : A
    {
        public void G()
        {
            // Console.WriteLine($"i: {i}"); // unaccessible instance variable
            Console.WriteLine($"F(5): {F(5)}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.G();
        }
    }
}
