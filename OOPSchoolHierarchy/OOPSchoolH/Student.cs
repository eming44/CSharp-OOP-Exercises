using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSchoolHierarchy
{
    class Student : Person
    {
        private int ucn; //unique class number
        private string commentOnStudent;

        public int GetUcn
        {
            get
            {
                return this.ucn;
            }
        }

        public string GetCommentOnStudent
        {
            get
            {
                return this.commentOnStudent;
            }

            set
            {
                this.commentOnStudent = value;
            }
        }

        public Student(string firstName, string lastName, int ucn) : base(firstName, lastName)
        {
            this.ucn = ucn;
            this.commentOnStudent = string.Empty;
        }

        public Student(string firstName, string lastName, int ucn, string commentOnStudent) : base(firstName, lastName)
        {
            this.ucn = ucn;
            this.commentOnStudent = commentOnStudent;
        }
    }
}
