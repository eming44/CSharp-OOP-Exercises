using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Problem_3.First_before_last
{
    class Student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }

        public int age { get; set; }


        public Student(string newFirstname, string newLastname, int newAge)
        {
            this.firstname = newFirstname;
            this.lastname = newLastname;
            this.age = newAge;
        }
    }
}
