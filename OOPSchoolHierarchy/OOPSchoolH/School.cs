using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSchoolHierarchy
{
    class School
    {
        private Dictionary<string, Class> classes;

        public School()
        {
            this.classes = new Dictionary<string, Class>();
        }

        public void AddClass(Class newClass)
        {
            if(!classes.ContainsKey(newClass.GetUtid))
            {
                this.classes.Add(newClass.GetUtid, newClass);
            }
            else
            {
                throw new ArgumentException("Class already exist!");
            }
        }

        public List<Class> ReturnAllClasses()
        {
            List<Class> allClasses = (from cl in this.classes
                                      select cl.Value).ToList();
            return allClasses;
        }

        public Class GetClassByID(string key)
        {
            return this.classes[key];
        }

        public int StudentsInClass(string key)
        {
            return this.classes[key].GetNumberOfStudents;
        }
    }
}
