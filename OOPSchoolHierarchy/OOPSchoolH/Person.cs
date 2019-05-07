using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSchoolHierarchy
{
    class Person
    {
        private string firstName;
        private string lastName;

        public string GetFirstName
        {
            get
            {
                return this.firstName;
            }
        }

       public string GetLastName
       {
           get
           {
               return this.lastName;
           }
       }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }




    }
}
