using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSchoolHierarchy
{
    class Discipline
    {
        private string name;
        private string commentOnDiscipline;
        private int lecturesCount;
        private int exercisesCount;

        public string GetCommentOnDiscipline
        {
            get
            {
                return this.commentOnDiscipline;
            }
        }

        public Discipline(string name, int lecturesCount, int exercisesCount)
        {
            this.name = name;
            this.lecturesCount = lecturesCount;
            this.exercisesCount = exercisesCount;
            this.commentOnDiscipline = string.Empty;
        }

        public Discipline(string name, int lecturesCount, int exercisesCount, string commentOnDiscipline)
        {
            this.name = name;
            this.lecturesCount = lecturesCount;
            this.exercisesCount = exercisesCount;
            this.commentOnDiscipline = commentOnDiscipline;
        }
    }
}
