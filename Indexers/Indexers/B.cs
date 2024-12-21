using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class B
    {
        private double d, e, f;

        public B(double v)
        {
            d = e = f = v;
        }

        public B()
        {
            d = e = f = 0;
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
