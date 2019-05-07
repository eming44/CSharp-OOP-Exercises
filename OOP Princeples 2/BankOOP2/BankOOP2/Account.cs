using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP2
{
    abstract class Account : Bank
    {
        protected accountTypes accountType;
        protected customerTypes customerType;
        protected decimal balance;
        protected int interestRate;
        protected int numberOfMonths;

        public Account(accountTypes newAccountType, customerTypes newCustomerType, decimal newBalance, int newInterestRate, int newNumberOfMonths)
        {
            this.accountType = newAccountType;
            this.customerType = newCustomerType;
            this.balance = newBalance;
            this.interestRate = newInterestRate;
            this.numberOfMonths = newNumberOfMonths;
        }

        public void MakeDeposit(decimal money)
        {
            this.balance += money;
        }
        virtual public int CalInterestAmount(int months)
        {
            int result = months * this.interestRate;
            return result;
        }
        public override string ToString()
        {
            return
                "Account type: " + this.accountType + 
                "\nCustomer type: " + this.customerType +
                "\nBalance: " + this.balance +
                "\nInterest rate: " + this.interestRate +
                "\nNumber of months: " + this.numberOfMonths +
                "\n-------------------------------";
        }
    }
}
