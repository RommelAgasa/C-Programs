using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount ba = new BankAccount("Peter", 1000);
            Console.WriteLine(ba);

            ba.Deposits(100);
            Console.WriteLine("Balance: {0}", ba.Balance);

            ba.Withdraws(300);
            Console.WriteLine("Balance: {0}", ba.Balance);

            ba.Deposits(100);
            Console.WriteLine("Balance: {0}", ba.Balance);

        }
    }
}
