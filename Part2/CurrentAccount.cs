using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class CurrentAccount : Account
    {
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(int accountNumber, string accountType, decimal balance, Customer customer, decimal overdraftLimit)
            : base(accountNumber, accountType, balance, customer)
        {
            OverdraftLimit = overdraftLimit;
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

        public override string ToString()
        {
            return base.ToString() + $", Overdraft Limit: {OverdraftLimit}";
        }
    }
}
