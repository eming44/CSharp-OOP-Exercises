using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSchoolHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Discipline> allDisciplines = new List<Discipline>();
            allDisciplines.Add(new Discipline("Physics", 4, 4));
            allDisciplines.Add(new Discipline("Math", 3, 4));
            allDisciplines.Add(new Discipline("ForeignLanguage", 4, 8));
            allDisciplines.Add(new Discipline("Programming", 4, 8));
            allDisciplines.Add(new Discipline("Art", 4, 4));
            allDisciplines.Add(new Discipline("Geography", 4, 4));

            List<Teacher> allTeachers = new List<Teacher>();

            allTeachers.Add(new Teacher("Lala", "Tata", allDisciplines[0]));
            allTeachers[0].AddDiscipline(allDisciplines[1]);

            allTeachers.Add(new Teacher("Bla", "Bla", allDisciplines[2]));
            allTeachers[1].AddDiscipline(allDisciplines[4]);

            allTeachers.Add(new Teacher("Foo", "Foo"));
            allTeachers[2].AddDiscipline(allDisciplines[3]);
            allTeachers[2].AddDiscipline(allDisciplines[5]);


            List<Student> allStudents = new List<Student>();
            allStudents.Add(new Student("ttt", "mmm", 1));
            allStudents.Add(new Student("mmm", "KKK", 2));
            allStudents.Add(new Student("ppp", "yyy", 3));
            allStudents.Add(new Student("aaa", "bbb", 4));
            allStudents.Add(new Student("www", "eee", 5));
            allStudents.Add(new Student("rrr", "ccc", 6));
            allStudents.Add(new Student("sss", "qqq", 7));
            allStudents.Add(new Student("zzz", "xxx", 8));

            List<Class> classes = new List<Class>();
            classes.Add(new Class("12a",
                                new Teacher[] { allTeachers[0], allTeachers[1] },
                                new Student[] { allStudents[0], allStudents[1], allStudents[2], allStudents[3] }));
            classes.Add(new Class("12b",
                                new Teacher[] { allTeachers[0], allTeachers[1] },
                                new Student[] { allStudents[4], allStudents[5], allStudents[6], allStudents[7] }));

            School school = new School();

            school.AddClass(classes[0]);
            school.AddClass(classes[1]);

            Class getClass = school.GetClassByID("12a");
            Console.WriteLine("Original\nclass: {0} \nstudents: {1}", getClass.GetUtid, getClass.GetNumberOfStudents);
            getClass.AddStudent(allStudents[5]);
            Console.WriteLine("\nAdded a student to a class -\nclass: {0} \nstudents: {1}", getClass.GetUtid, getClass.GetNumberOfStudents);
            getClass.RemoveStudent(allStudents[0]);
            Console.WriteLine("\nRemoved a student -\nclass: {0} \nstudents: {1}", getClass.GetUtid, getClass.GetNumberOfStudents);
            getClass.GetCommentOnClass = "avoid eye contact";
            Console.WriteLine("\nRemoved a student -\nclass: {0} \nstudents: {1}\nComment: {2}", getClass.GetUtid, getClass.GetNumberOfStudents, getClass.GetCommentOnClass);







        }
    }
}
