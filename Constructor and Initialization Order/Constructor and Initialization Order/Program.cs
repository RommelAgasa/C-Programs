using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_and_Initialization_Order
{

    public class Init
    {
        public static int InitMe(int val, string who)
        {
            Console.WriteLine(who);
            return val;
        }
    }

    public class A
    {
        private int varA1 = Init.InitMe(1, "varA1, initializer in class A"),
                    varA2;
        public A()
        {
            varA2 = Init.InitMe(4, "vaA2, initializer in constructor body A");
        }
    }

    public class B : A
    {
        private int varB1 = Init.InitMe(1, "varB1, initializer in class B"),
            varB2;

        public B()
        {
            varB2 = Init.InitMe(4, "varB2, initializer in constructor body B");
        }
    }

    public class C : B
    {
        private int varC1 = Init.InitMe(1, "varC1, initializer in class C"),
            varC2;

        public C()
        {
            varC2 = Init.InitMe(4, "varC2, initializer in constructor body C");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
        }
    }
}
