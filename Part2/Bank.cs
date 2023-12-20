using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class Bank
    {
        private List<Account> accounts = new List<Account>();

        public void CreateAccount(Customer customer, int accountNumber, string accountType, decimal balance, decimal interestRateOrOverdraftLimit)
        {
            if (accountType == "Savings")
            {
                accounts.Add(new SavingsAccount(accountNumber, accountType, balance, customer, interestRateOrOverdraftLimit));
            }
            else if (accountType == "Current")
            {
                accounts.Add(new CurrentAccount(accountNumber, accountType, balance, customer, interestRateOrOverdraftLimit));
            }
        }

        public Account GetAccount(int accountNumber)
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
