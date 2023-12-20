using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class CustomerServiceProviderImpl : ICustomerServiceProvider
    {
        protected List<Account> accounts = new List<Account>();

        public decimal GetAccountBalance(int accountNumber)
        {
            return accounts.Find(account => account.AccountNumber == accountNumber)?.Balance ?? 0;
        }

        public void Deposit(int accountNumber, float amount)
        {
            Account account = accounts.Find(account => account.AccountNumber == accountNumber);
            if (account != null)
            {
                account.Balance += (decimal)amount;
            }
        }

        public void Withdraw(int accountNumber, float amount)
        {
            Account account = accounts.Find(account => account.AccountNumber == accountNumber);
            if (account != null && account.Balance >= (decimal)amount)
            {
                account.Balance -= (decimal)amount;
            }
        }

        public void Transfer(int fromAccountNumber, int toAccountNumber, float amount)
        {
            Account fromAccount = accounts.Find(account => account.AccountNumber == fromAccountNumber);
            Account toAccount = accounts.Find(account => account.AccountNumber == toAccountNumber);
            if (fromAccount != null && toAccount != null && fromAccount.Balance >= (decimal)amount)
            {
                fromAccount.Balance -= (decimal)amount;
                toAccount.Balance += (decimal)amount;
            }
        }

        public string GetAccountDetails(int accountNumber)
        {
            return accounts.Find(account => account.AccountNumber == accountNumber)?.ToString();
        }
    }
}
