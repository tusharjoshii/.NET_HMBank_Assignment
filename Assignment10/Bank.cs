using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    public class Bank
    {
        private List<Account> accounts = new List<Account>();
        private int lastAccountNumber = 1000;

        public void CreateAccount(Customer customer, string accountType, decimal balance)
        {
            int accountNumber = ++lastAccountNumber;
            accounts.Add(new Account(accountNumber, accountType, balance, customer));
        }

        public Account GetAccount(int accountNumber)
        {
            return accounts.Find(account => account.AccountNumber == accountNumber);
        }

        public decimal GetAccountBalance(int accountNumber)
        {
            return GetAccount(accountNumber)?.Balance ?? 0;
        }

        public void Deposit(int accountNumber, float amount)
        {
            Account account = GetAccount(accountNumber);
            if (account != null)
            {
                account.Balance += (decimal)amount;
            }
        }

        public void Withdraw(int accountNumber, float amount)
        {
            Account account = GetAccount(accountNumber);
            if (account != null && account.Balance >= (decimal)amount)
            {
                account.Balance -= (decimal)amount;
            }
        }

        public void Transfer(int fromAccountNumber, int toAccountNumber, float amount)
        {
            Account fromAccount = GetAccount(fromAccountNumber);
            Account toAccount = GetAccount(toAccountNumber);
            if (fromAccount != null && toAccount != null && fromAccount.Balance >= (decimal)amount)
            {
                fromAccount.Balance -= (decimal)amount;
                toAccount.Balance += (decimal)amount;
            }
        }

        public string GetAccountDetails(int accountNumber)
        {
            return GetAccount(accountNumber)?.ToString();
        }
    }

}
