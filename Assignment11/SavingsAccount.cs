using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string accountType, decimal balance, Customer customer, decimal interestRate)
            : base(accountType, balance, customer)
        {
            InterestRate = interestRate;
        }

        public override string ToString()
        {
            return base.ToString() + $", Interest Rate: {InterestRate}";
        }
    }
}
