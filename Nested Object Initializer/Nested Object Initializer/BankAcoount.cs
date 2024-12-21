using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Object_Initializer
{
    internal class BankAcoount
    {
        public BankAcoount()
        {
            this.Balance = 0;
            this.Owner = new Person();
        }

        public Person Owner { get; set; }
        public decimal Balance { get; set; }

        public override string ToString()
        {
            return Owner + "'s account holds " + Balance + " kroner";
        }
    }
}
