using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public Customer Customer { get; set; }

        public Account() { }

        public Account(int accountNumber, string accountType, decimal balance, Customer customer)
        {
            AccountNumber = accountNumber;
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
