using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP2
{
    class LoanAccount : Account
    {
        public LoanAccount(customerTypes newCustomerType, decimal newBalance, int newInterestRate, int newNumberOfMonths) 
            : base (accountTypes.loan, newCustomerType, newBalance, newInterestRate, newNumberOfMonths)
        {
           
        }

        public override int CalInterestAmount(int months)
        {
            if ((this.customerType.Equals(customerTypes.individuals) && this.numberOfMonths <= 3) ||
                (this.customerType.Equals(customerTypes.companies) && this.numberOfMonths <= 2))
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
