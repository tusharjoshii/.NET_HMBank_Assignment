using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    public class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(int accountNumber, string customerName, decimal balance, decimal overdraftLimit)
            : base(accountNumber, customerName, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Deposit(float amount)
        {
            Balance += (decimal)amount;
        }

        public override void Withdraw(float amount)
        {
            if (Balance + OverdraftLimit >= (decimal)amount)
            {
                Balance -= (decimal)amount;
            }
            else
            {
                Console.WriteLine("Overdraft limit exceeded.");
            }
        }

        public override void CalculateInterest()
        {

        }

        public override string ToString()
        {
            return base.ToString() + $", Overdraft Limit: {OverdraftLimit}";
        }
    }
}
