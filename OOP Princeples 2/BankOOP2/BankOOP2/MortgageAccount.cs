using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP2
{
    class MortgageAccount : Account
    {
        public MortgageAccount(customerTypes newCustomerType, decimal newBalance, int newInterestRate, int newNumberOfMonths) 
            : base (accountTypes.mortgage, newCustomerType, newBalance, newInterestRate, newNumberOfMonths)
        {
           
        }

        public override int CalInterestAmount(int months)
        {
            if (this.customerType.Equals(customerTypes.companies) && this.numberOfMonths <= 12)
            {
                return base.CalInterestAmount(months) / 2;
            }
            else if (this.customerType.Equals(customerTypes.individuals) && this.numberOfMonths <= 6)
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
