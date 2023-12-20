using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public interface ICustomerServiceProvider
    {
        decimal GetAccountBalance(int accountNumber);
        void Deposit(int accountNumber, float amount);
        void Withdraw(int accountNumber, float amount);
        void Transfer(int fromAccountNumber, int toAccountNumber, float amount);
        string GetAccountDetails(int accountNumber);
    }
}
