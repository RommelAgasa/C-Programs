using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    public static class StringExtensions
    {

        // this keyword use to binding this method to the String Class Only
        public static string RightSubtring(this String s, int count)
        {
            return s.Substring(s.Length - count, count);
        }
    }

    class A
    {
        private int x;

        public A()
        {
            this.x = 0;
        }
    }

    class B : A
    {
        private int y;

        B(int y)
        {
            this.y = y;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            string test = "Hello World";

            string left = test.Substring(0, 5);
            string right = test.RightSubtring(5);

            Console.WriteLine(left + " " + right);

        }
    }


    
}
