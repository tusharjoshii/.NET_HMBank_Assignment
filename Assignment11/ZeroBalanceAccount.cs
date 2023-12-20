using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class ZeroBalanceAccount : Account
    {
        public ZeroBalanceAccount(string accountType, Customer customer)
            : base(accountType, 0, customer)
        {
        }
    }
}
