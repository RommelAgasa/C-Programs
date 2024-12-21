using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStruct
{
    internal class Program
    {

        public struct Nullable<T> where T: struct
        {
            private T value;
            private bool hasValue;

            public Nullable(T value)
            {
                this.value = value;
                this.hasValue = true;
            }

            public bool HasValue
            {
                get { 
                    if(hasValue)
                        return true;
                    else throw new InvalidOperationException();
                }
            }

            public T Value
            {
                get
                {
                    if (hasValue)
                    {
                       return value;
                    }
                    else throw new InvalidOperationException();
                }
            }


        }

        public struct A
        {
            public string Value { get; set; }
            public int Key { get; set; }
        }
        static void Main(string[] args)
        {
            A a = new A();
            a.Value = "Kyla Basierto";
            a.Key = 123;
            Nullable<A> n = new Nullable<A>(a);

            Console.WriteLine(n.HasValue);
            A b = n.Value;
            Console.WriteLine(b.Value);

        }
    }
}
