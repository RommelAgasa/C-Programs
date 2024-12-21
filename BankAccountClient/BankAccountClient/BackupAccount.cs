
namespace BankAccountClient
{
    internal class BackupAccount
    {
        public decimal balance;

        public BackupAccount()
        {
            this.balance = 0.0M;
        }

        public BackupAccount(decimal balance)
        {
            this.balance = balance;
        }
    }
}
