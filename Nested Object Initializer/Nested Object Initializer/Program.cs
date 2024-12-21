using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Object_Initializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAcoount ba1 = new BankAcoount
            {
                Owner = { FirstName = "James", LastName = "Madsen" },
                Balance = 250
            },

            ba2 = new BankAcoount
            {
                Owner = { FirstName = "Bill", LastName = "Jensen" },
                Balance = 500
            };

            Console.WriteLine(ba1);
            Console.WriteLine(ba2);

        }
    }
}
