using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(int accountNumber, string accountType, decimal balance, Customer customer, decimal interestRate)
            : base(accountNumber, accountType, balance, customer)
        {
            InterestRate = interestRate;
        }

        public override void CalculateInterest()
        {
            Balance += Balance * InterestRate;
        }

        public override string ToString()
        {
            return base.ToString() + $", Interest Rate: {InterestRate}";
        }
    }
}
