using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class BankServiceProviderImpl : CustomerServiceProviderImpl, IBankServiceProvider
    {
        protected List<Account> accounts = new List<Account>();
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }

        public void CreateAccount(Customer customer, string accountType, decimal balance)
        {
            if (accountType == "Savings")
            {
                accounts.Add(new SavingsAccount(accountType, balance, customer, 0.03m));
            }
            else if (accountType == "Current")
            {
                accounts.Add(new CurrentAccount(accountType, balance, customer, 1000m));
            }
            else if (accountType == "ZeroBalance")
            {
                accounts.Add(new ZeroBalanceAccount(accountType, customer));
            }
        }

        public List<Account> ListAccounts()
        {
            return accounts;
        }

        public void CalculateInterest(int accountNumber)
        {
       
        }
    }
}
