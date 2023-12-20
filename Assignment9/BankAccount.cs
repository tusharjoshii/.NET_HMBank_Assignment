using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    public abstract class BankAccount
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal Balance { get; set; }

        public BankAccount() { }

        public BankAccount(int accountNumber, string customerName, decimal balance)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Balance = balance;
        }

        public abstract void Deposit(float amount);

        public abstract void Withdraw(float amount);

        public abstract void CalculateInterest();

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}, Customer Name: {CustomerName}, Balance: {Balance}";
        }
    }
}
