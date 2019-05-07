using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSchoolHierarchy
{
    class Teacher : Person
    {
        private List<Discipline> disciplines;
        private string commentOnTeacher;

        public string GetCommentOnTeacher
        {
            get
            {
                return this.commentOnTeacher;
            }
        }

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
            this.disciplines = new List<Discipline>();
            this.commentOnTeacher = string.Empty;
        }

        public Teacher(string firstName, string lastName, string commentOnStudent)
            : base(firstName, lastName)
        {
            this.disciplines = new List<Discipline>();
            this.commentOnTeacher = commentOnStudent;
        }

        public Teacher(string firstName, string lastName, Discipline discipline)
            : base(firstName, lastName)
        {
            this.disciplines = new List<Discipline>();
            this.disciplines.Add(discipline);
            this.commentOnTeacher = string.Empty;
        }
        public Teacher(string firstName, string lastName, string commentOnStudent, Discipline discipline)
            : base(firstName, lastName)
        {
            this.disciplines = new List<Discipline>();
            this.disciplines.Add(discipline);
            this.commentOnTeacher = commentOnStudent;
        }

        public void AddDiscipline(Discipline disc)
        {
            this.disciplines.Add(disc);
        }

        public void RemoveDiscipline(Discipline disc)
        {
            this.disciplines.Remove(disc);
        }

        public List<Discipline> ReturnDisciplines()
        {
            List<Discipline> allDisc = (from disc in this.disciplines
                                        select disc).ToList();
            return allDisc;
        }
    }
}
