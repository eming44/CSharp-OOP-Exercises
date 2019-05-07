using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP2
{
    class DepositAccount : Account
    {
        public DepositAccount(customerTypes newCustomerType, decimal newBalance, int newInterestRate, int newNumberOfMonths) 
            : base (accountTypes.deposit, newCustomerType, newBalance, newInterestRate, newNumberOfMonths)
        {
           
        }

        public void WithdrawMoney(decimal money)
        {
            this.balance -= money;
        }

        public override int CalInterestAmount(int months)
        {
            if (this.balance > 0 && this.balance <= 1000)
            {
                return 0;
            }
            else if (this.balance < 0)
            {
                return 0;
            }
            else
            {
                return base.CalInterestAmount(months);
            }
        }
    }
}
