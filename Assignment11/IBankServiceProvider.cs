using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public interface IBankServiceProvider : ICustomerServiceProvider
    {
        void CreateAccount(Customer customer, string accountType, decimal balance);
        List<Account> ListAccounts();
        void CalculateInterest(int accountNumber);
    }
}
