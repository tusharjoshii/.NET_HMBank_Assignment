using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    public class Bank
    {
        private List<BankAccount> accounts = new List<BankAccount>();

        public void CreateAccount(BankAccount account)
        {
            accounts.Add(account);
        }

        public BankAccount GetAccount(int accountNumber)
        {
            return accounts.Find(account => account.AccountNumber == accountNumber);
        }

        public void Deposit(int accountNumber, float amount)
        {
            GetAccount(accountNumber)?.Deposit(amount);
        }

        public void Withdraw(int accountNumber, float amount)
        {
            GetAccount(accountNumber)?.Withdraw(amount);
        }

        public void CalculateInterest(int accountNumber)
        {
            GetAccount(accountNumber)?.CalculateInterest();
        }
    }
}
