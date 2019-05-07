using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test deposit accounts-----------------------------
            DepositAccount daFirst = new DepositAccount(Bank.customerTypes.individuals, 4000, 2, 5);
            Console.WriteLine(daFirst.ToString());
            daFirst.MakeDeposit(500);
            Console.WriteLine(daFirst.ToString());
            daFirst.WithdrawMoney(130);
            Console.WriteLine(daFirst.ToString());
            Console.WriteLine(daFirst.CalInterestAmount(6));
            DepositAccount daSecond = new DepositAccount(Bank.customerTypes.individuals, 800, 2, 5); //Deposit account with balance less than 1000
            Console.WriteLine(daSecond.ToString());
            Console.WriteLine(daSecond.CalInterestAmount(3));

            //Test loan accounts--------------------------------
            LoanAccount lai = new LoanAccount(Bank.customerTypes.individuals, 4000, 2, 0); //Loan account individual
            Console.WriteLine(lai.ToString());
            Console.WriteLine(lai.CalInterestAmount(2));
        }
    }
}
