using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    internal class Singleton
    {
        private static Singleton instance = null;


        private Singleton()
        {
            // Initialization of instance variables
        }

        public static Singleton Instance()
        {
            if(instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}
