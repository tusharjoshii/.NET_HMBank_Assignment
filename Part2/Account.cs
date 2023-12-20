using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
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

        public virtual void Deposit(float amount)
        {
            Balance += (decimal)amount;
        }

        public virtual void Deposit(int amount)
        {
            Balance += amount;
        }

        public virtual void Deposit(double amount)
        {
            Balance += (decimal)amount;
        }

        public virtual void Withdraw(float amount)
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

        public virtual void Withdraw(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public virtual void Withdraw(double amount)
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

        public virtual void CalculateInterest()
        {
      
        }

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}, Account Type: {AccountType}, Balance: {Balance}, Customer: {Customer.ToString()}";
        }
    }
}
