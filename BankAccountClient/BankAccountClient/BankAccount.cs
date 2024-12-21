using System;


namespace BankAccountClient
{
    internal class BankAccount
    {
        private double interestRate;
        private string owner;
        private decimal balance;
        private long accountNumber;
        BackupAccount backup;
        

        public BankAccount(string owner)
        {
            backup = new BackupAccount();
            this.interestRate = 0.0;
            this.owner = owner;
            this.balance = 0.0M;
        }

        public BankAccount(string owner, double ineterestRate)
        {
            backup = new BackupAccount();
            this.interestRate = ineterestRate;
            this.owner = owner;
            this.balance = 0.0M;
        }

        public BankAccount(string owner, double ineterestRate, decimal balance)
        {
            backup = new BackupAccount();
            this.interestRate = ineterestRate;
            this.owner = owner;
            this.balance = balance;
        }

        public BankAccount(string owner, long accountNumber, double ineterestRate, 
            decimal balance, decimal backupMoney)
        {
            this.interestRate = ineterestRate;
            this.owner = owner;
            this.accountNumber = accountNumber;
            this.balance = balance;
            backup = new BackupAccount(backupMoney);
        }

        public void Deposit(decimal amount)
        {
            if (!LogTransaction())
            {
                Console.WriteLine("\nInvalid Account Number. Cannot proceed to the transaction.\n");
                return;
            }
            balance = amount;
        }

        public bool Withdraw(decimal withdraw)
        {

            if (!LogTransaction())
            {
                Console.WriteLine("\nInvalid Account Number. Cannot proceed to the transaction.\n");
                return false;
            }


            if (withdraw < balance)
            {
                balance -= withdraw;
                return true;
            }
            else
            {
                decimal allBalance = balance + backup.balance;
                if (withdraw < allBalance)
                {
                    decimal temp = withdraw - balance;
                    backup.balance -= temp;
                    balance = 0;
                    return true;
                }
                    return false;
            }
        }

        public bool LogTransaction()
        {
            long accNum = 0L;
            Console.WriteLine("\nPlease enter your account number: ");
            accNum = long.Parse(Console.ReadLine());

            if (accNum.Equals(this.accountNumber)) return true;

            return false;
        }

        public void AddMoneyBackup(decimal backupMoney)
        {
            backup.balance += backupMoney;
        }

        public void AddInterest()
        {
            this.balance = this.balance + (this.balance * (decimal)this.interestRate);
        }

        override public string ToString()
        {
            return "Account Owner: " + owner + "\n" +
                "Interest Rate: " + interestRate + "\n" +
                "Balance :" + balance + "\n" +
                "Backup Money: " + backup.balance;
        }


    }
}
