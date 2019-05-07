using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP2
{
    abstract class Bank
    {
        public enum accountTypes
        {
            deposit,
            loan,
            mortgage
        }
        public enum customerTypes
        {
            individuals,
            companies
        }
    }
}
