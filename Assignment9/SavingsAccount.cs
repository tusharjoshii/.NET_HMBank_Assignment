using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(int accountNumber, string customerName, decimal balance, decimal interestRate)
            : base(accountNumber, customerName, balance)
        {
            InterestRate = interestRate;
        }

        public override void Deposit(float amount)
        {
            Balance += (decimal)amount;
        }

        public override void Withdraw(float amount)
        {
            if (Balance >= (decimal)amount)
            {
                Balance -= (decimal)amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
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
