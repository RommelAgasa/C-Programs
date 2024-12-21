using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountClient
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //BankAccount a1 = new BankAccount("Kurt", 0.02),
            //            a2 = new BankAccount("Bent", 0.03),
            //            a3 = new BankAccount("Thomas", 0.02);

            //a1.Deposit(100.0M);
            //a2.Deposit(1000.0M); a2.AddInterest();
            //a3.Deposit(3000.0M); a3.AddInterest();


            //Console.WriteLine(a1); // 100 kr. 
            //Console.WriteLine(); 
            //Console.WriteLine(a2); // 1030 kr. 
            //Console.WriteLine();
            //Console.WriteLine(a3); // 3060 kr.


            BankAccount a4 = new BankAccount("Rommel", 123444, 0.04, 500, 100);
            Console.WriteLine(a4);
            a4.Withdraw(550);
            Console.WriteLine();
            Console.WriteLine(a4);
            a4.AddMoneyBackup(50);
            Console.WriteLine();
            Console.WriteLine(a4);
        }
    }
}
