using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountVersion2
{
    internal class BankAccount
    {
        private double interestRate;
        private string owner;
        private decimal balance;
        private long accountNumber;

        private static long nextAccountNumber = 0;
        private static ArrayList accounts = new ArrayList();

        public BankAccount(string owner)
        {
            nextAccountNumber++;
            accounts.Add(this);
            this.accountNumber = nextAccountNumber;
            this.interestRate = 0.0;
            this.owner = owner;
            this.balance = 0.0M;
        }

        public BankAccount(string owner, double interestRate)
        {
            nextAccountNumber++;
            accounts.Add(this);
            this.accountNumber = nextAccountNumber;
            this.interestRate = interestRate;
            this.owner = owner;
            this.balance = 0.0M;
        }

        public static long NumberOfAccounts()
        {
            return nextAccountNumber;
        }

        public static BankAccount GetAccount(long accountNumber)
        {
            if(accountNumber > nextAccountNumber) return null;
            foreach(BankAccount account in accounts)
                if(account.accountNumber == accountNumber)
                    return account;
            return null;
        }

        public void Deposit(decimal desposit)
        {
            this.balance += desposit;
        }

        public void AddInterests()
        {
            this.balance = balance + (this.balance * (decimal)this.interestRate);
        }

        public override string ToString()
        {
            return owner + "'s account, no. " + accountNumber + " holds " +
            + balance + " pesos.";
        }

    }
}
