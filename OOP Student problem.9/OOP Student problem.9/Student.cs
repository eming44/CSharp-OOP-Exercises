using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Student_problem._9
{
    public class Student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string fn { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public int groupNumber { get; set; }

        public List<int> marks = new List<int>();

        public Student(string Firstname, string Lastname, string FN, string Tel, string Email, int GroupNumber, int[] newMarks)
        {
            this.firstname = Firstname;
            this.lastname = Lastname;
            this.fn = FN;
            this.tel = Tel;
            this.email = Email;
            this.groupNumber = GroupNumber;
            foreach (var item in newMarks)
            {
                this.marks.Add(item);
            }
        }  
 
        public string takeMarks()
        {
            string allMarks = "";
            foreach (var item in marks)
            {
                allMarks += item + " ";
            }
            return allMarks;
        }
    }
}
