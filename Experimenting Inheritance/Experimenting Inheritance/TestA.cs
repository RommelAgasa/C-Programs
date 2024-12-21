using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Experimenting_Inheritance
{
    internal class TestA
    {
        protected int firstValueProtected;  // protected members are visible only in derived class 
        internal int secondValueInternal;
        private int thirdValuePrivate;
        public int fourthValuePublic;

        static public string statVal1;
        static public string statVal2;

        // A static constructor must be parameterless
        //static TestA(string val1, int val2)
        //{
        //    statVal1 = val1;
        //}


        // Static Constructor cannot be inherited by the derived class
        static TestA()
        {
            statVal1 = "just random string1";
            statVal2 = "just random string2";
        }

        
        // Internal members are visible only in derived classes that are located in 
        // the same assembly as the base class

        // Public members are visible in derived class(child class) and are part
        // of the derived class' public interface
        public TestA(int firstValueProtected, int secondValueInternal, int thirdValuePrivate, int fourthValuePublic)
        {
            this.firstValueProtected = firstValueProtected;
            this.secondValueInternal = secondValueInternal;
            this.thirdValuePrivate = thirdValuePrivate;
            this.fourthValuePublic = fourthValuePublic;
        }

        public void printMessagePublic()
        {
            Console.WriteLine("Hey Im in a Class TestA printing from the public method");
        }

        private void printMessagePrivate()
        {
            Console.WriteLine("Hey Im in a Class TestA printing from the private method");
        }

        protected void printMessageProtected()
        {
            Console.WriteLine("Hey Im in a Class TestA printing from the protected method");
        }

        internal void printMessageInternal()
        {
            Console.WriteLine("Hey Im in a Class TestA printing from the internal method");
        }

        static void printMessageStatic()
        {
            Console.WriteLine("Hey Im in a Class TestA printing from the static method");
        }

        public int fValue
        {
            get { return firstValueProtected; }
            set { firstValueProtected = value; }
        }

        

    }
}
