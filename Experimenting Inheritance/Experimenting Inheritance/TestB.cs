using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimenting_Inheritance
{
    internal class TestB : TestA
    {

        protected int firstValueFromB;

        public TestB(int firstValue, int firstValueProtected, int secondValueInternal, int thirdValuePrivate, int fourthValuePublic) : 
            base (firstValueProtected, secondValueInternal, thirdValuePrivate, fourthValuePublic)
        {
            
            firstValueFromB = firstValue;
        }



        public void printProtectedFromClassTestA()
        {
            Console.WriteLine("From class TestB printing Message From class ClassA");
            printMessageProtected();
        }


        // protected members are visible only in derived class 
        public void printProtectedMem()
        {
            Console.WriteLine(this.firstValueProtected);
        }

        public void changeValueOfProtected(int num)
        {
            this.firstValueProtected = num;
        }


        // not visible in the derived class
        //public void printPrivateMem()
        //{
        //    Console.WriteLine(this.thirdValuePrivate);
        //}


    }
}
