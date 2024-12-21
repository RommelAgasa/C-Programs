using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class A
    {

        private double d, e, f;

        public A(double v)
        {
            d = e = f = v;
        }


        // Indexers can be overloaded
        public double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 1: { return d; }
                    case 2: { return e; }
                    case 3: { return f; }
                    default: throw new Exception("Error");
                }
            }
            set
            {
                switch (i)
                {
                    case 1: { d = value; break; }
                    case 2: { e = value; break; }
                    case 3: { f = value; break; }
                    default: throw new Exception("Error");
                }
            }
        }

        public double this[string i]
        {
            get
            {
                switch (i)
                {
                    case "d": { return d; }
                    case "e": { return e; }
                    case "f": { return f; }
                    default: throw new Exception("Error");
                }
            }
            set
            {
                switch (i)
                {
                    case "d": { d = value; break; }
                    case "e": { e = value; break; }
                    case "f": { f = value; break; }
                    default: throw new Exception("Error");
                }
            }
        }


        public override string ToString()
        {
            return "A: " + d + ", " + e + ", " + f;
        }
    }
}
