using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class CurrentAccount : Account
    {
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(string accountType, decimal balance, Customer customer, decimal overdraftLimit)
            : base(accountType, balance, customer)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override string ToString()
        {
            return base.ToString() + $", Overdraft Limit: {OverdraftLimit}";
        }
    }
}
