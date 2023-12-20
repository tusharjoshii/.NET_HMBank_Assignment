using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class Account
    {
        public static int LastAccountNumber = 1000;
        public int AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public Customer Customer { get; set; }

        public Account() { }

        public Account(string accountType, decimal balance, Customer customer)
        {
            AccountNumber = ++LastAccountNumber;
            AccountType = accountType;
            Balance = balance;
            Customer = customer;
        }

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}, Account Type: {AccountType}, Balance: {Balance}, Customer: {Customer.ToString()}";
        }
    }
}
