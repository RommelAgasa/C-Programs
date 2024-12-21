using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    internal class BankAccount
    {
        private string owner;
        private decimal[] contributions;
        private int nextContributions;

        public BankAccount(string owner, decimal balance)
        {
            this.owner = owner;
            this.contributions = new decimal[100];
            this.contributions[0] = balance;
            this.nextContributions = 1;
        }


        public decimal Balance
        {
            get
            {
                decimal results = 0.0m;
                foreach (decimal ctr in contributions)
                    results += ctr;
                return results;
            }
        }

        public void Deposits(Decimal amount)
        {
            contributions[nextContributions] += amount;
            nextContributions++;
        }

        public void Withdraws(Decimal amount)
        {
            contributions[nextContributions] -= amount;
            nextContributions++;
        }

        public override string ToString()
        {
            return owner + "'s account holds " + Balance + "pesos.";
        }


    }
}
