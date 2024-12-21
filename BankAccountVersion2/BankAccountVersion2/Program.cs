using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BankAccountVersion2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            BankAccount a1 = new BankAccount("Kurt", 0.02),
                        a2 = new BankAccount("Bent", 0.03),
                        a3 = new BankAccount("Thomas", 0.02);

            a1.Deposit(100.0M);
            a2.Deposit(1000.0M); a2.AddInterests();
            a3.Deposit(3000.0M); a3.AddInterests();

            Console.WriteLine("Please enter the account number: ");
            long accN = long.Parse(Console.ReadLine());

            BankAccount a = BankAccount.GetAccount(accN);
            if (a != null)
                Console.WriteLine(a);
            else
                Console.WriteLine("Cannot find account {0}", accN);

            //Program t = new Program();
            //t.Test();
        }


        // <--  AN OBJECT REFERENCE IS REQUIRED FOR THE NONSTATIC FIELD -->


        //BankAccount a1 = new BankAccount("Kurt", 0.02),
        //                a2 = new BankAccount("Bent", 0.03),
        //                a3 = new BankAccount("Thomas", 0.02);

        //public void Test()
        //{
        //    a1.Deposit(100.0M);
        //    a2.Deposit(1000.0M); a2.AddInterests();
        //    a3.Deposit(3000.0M); a3.AddInterests();

        //    Console.WriteLine("Please enter the account number: ");
        //    long accN = long.Parse(Console.ReadLine());

        //    BankAccount a = BankAccount.GetAccount(accN);
        //    if (a != null)
        //        Console.WriteLine(a);
        //    else
        //        Console.WriteLine("Cannot find account {0}", accN);
        //}
    }
    
}
