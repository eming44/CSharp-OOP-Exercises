using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSchoolHierarchy
{
    class Class
    {
        private string utid;//unique text indentifier
        private string commentOnClass;
        private List<Teacher> setOfTeachers;
        private List<Student> setOfStudents;

        public string GetUtid
        {
            get
            {
                return this.utid;
            }
        }

        public string GetCommentOnClass
        {
            get
            {
                return this.commentOnClass;
            }
            set
            {
                this.commentOnClass = value;
            }
        }

        public Class(string uniqueClassID)
        {
            this.utid = uniqueClassID;
            this.setOfTeachers = new List<Teacher>();
            this.setOfStudents = new List<Student>();
            this.commentOnClass = string.Empty;
        }

        public Class(string uniqueClassID, Teacher[] teachers, Student[] students)
        {
            this.utid = uniqueClassID;
            this.setOfTeachers = new List<Teacher>();
            this.setOfStudents = new List<Student>();
            this.commentOnClass = string.Empty;

            foreach (var item in teachers)
            {
                this.setOfTeachers.Add(item);
            }

            foreach (var item in students)
            {
                this.setOfStudents.Add(item);
            }
        }

        public Class(string uniqueClassID, Teacher[] teachers, Student[] students, string commentOnClass)
        {
            this.utid = uniqueClassID;
            this.setOfTeachers = new List<Teacher>();
            this.setOfStudents = new List<Student>();
            this.commentOnClass = commentOnClass;

            foreach (var item in teachers)
            {
                this.setOfTeachers.Add(item);
            }

            foreach (var item in students)
            {
                this.setOfStudents.Add(item);
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            if(!setOfTeachers.Contains(teacher))
            {
                this.setOfTeachers.Add(teacher);
            }
            else
            {
                throw new ArgumentException("Teacher is already here!");
            }
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.setOfTeachers.Remove(teacher);
        }

        public void AddStudent(Student student)
        {
            if(!setOfStudents.Contains(student))
            {
                this.setOfStudents.Add(student);
            }
            else
            {
                throw new ArgumentException("Student is already here!");
            }
        }

        public void RemoveStudent(Student student)
        {
            this.setOfStudents.Remove(student);
        }

        public int GetNumberOfStudents
        {
            get
            {
                return this.setOfStudents.Count;
            }
        }

        public int GetNumberOfTeachers
        {
            get
            {
                return this.setOfTeachers.Count;
            }
        }


    }
}
