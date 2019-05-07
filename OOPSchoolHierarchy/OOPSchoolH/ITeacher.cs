using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSchoolHierarchy
{
    interface ITeacher
    {
        string GetCommentOnTeacher
        {
            get;
        }

        void AddDisciplines(Discipline disc);
        void RemoveDiscipline(Discipline disc);
        List<Discipline> ReturnDisciplines();
    }
}
