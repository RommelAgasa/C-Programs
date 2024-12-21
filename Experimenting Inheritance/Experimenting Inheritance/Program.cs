using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimenting_Inheritance
{
    internal class Program 
    {

        private int val;
        class program : Program
        {

            // private members are visible only in derived classes that are nested 
            // in their base class, Otherwise they are not visible in derived class
            public void changeValue(int n)
            {
                val = n;
            }
        }

        static void Main(string[] args)
        {

            //TestB test1 = new TestB(1, 2, 3, 4, 5);
            //test1.printProtectedFromClassTestA();
            //Console.WriteLine(test1.secondValueInternal);
            //test1.printProtectedMem();
            //test1.changeValueOfProtected(1);
            //test1.printProtectedMem();
            //test1.firstValueProtected = 1;   --> cannot access due to protection level


            //Console.WriteLine(test1.firstValueProtected);
            // static concept same as in java they are independent in object of the class
            TestA test2 = new TestA(3, 4, 5, 1);
            test2.fValue = 2;
            TestA.statVal2 = "";
            int c = test2.fValue;
            //Console.WriteLine(test2.fValue);
            //Console.WriteLine(c);
            Console.WriteLine(test2.fourthValuePublic);
            test2.fourthValuePublic = 3;
            Console.WriteLine(test2.fourthValuePublic);
        }
    }
}
