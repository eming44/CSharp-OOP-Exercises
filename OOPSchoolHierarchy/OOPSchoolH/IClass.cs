using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSchoolHierarchy
{
    interface IClass
    {
        string GetUtid
        {
            get;
        }
        string GetCommentOnClass
        {
            get;
        }
        void AddTeacher(Teacher teacher);
        void RemoveTeacher(Teacher teacher);
        void AddStudent(Student student);
        void RemoveStudent(Student student);
        int GetNumberOfStudents
        {
            get;
        }
        int GetNumberOfTeachers
        {
            get;
        }
    }
}
