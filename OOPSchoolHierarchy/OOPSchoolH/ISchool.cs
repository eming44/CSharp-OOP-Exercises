using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSchoolHierarchy
{
    interface ISchool
    {
        void AddClass(Class newClass);
        List<Class> ReturnAllClasses();
        Class GetClassByID(string key);
        int StudentsInClass(string key);

    }
}
