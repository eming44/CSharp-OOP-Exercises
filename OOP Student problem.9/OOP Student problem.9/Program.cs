using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Student_problem._9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Georgi", "Toshev", "Georg06i Aeds Toshev", "0894558811", "rex@gmail.com", 1, new int[] {2, 3, 4}));
            students.Add(new Student("Ivan", "Dachev", "Ivan Evwomv Dachev", "0891882255", "jacob@abv.bg", 2, new int[] { 6, 6, 1 }));
            students.Add(new Student("Boqn", "Dimitrov", "Boqn 06Obroe Dimitrov", "0893569812", "kamenica@yahoo.com", 2, new int[] { 4, 3, 4 }));
            students.Add(new Student("Malinka", "Gesheva", "Malinka Bwweer Gesheva", "0899237612", "vilq@abv.bg", 1, new int[] { 6, 5, 4 }));
            students.Add(new Student("Stancho", "Stoichev", "Stancho Qqfwefw Stoichev", "0897560911", "query@abv.bg", 1, new int[] { 2, 2, 4 }));
            students.Add(new Student("Bilqna", "Zeneva", "Bilqna Viwner Zeneva", "0894667130", "manga@gmail", 2, new int[] { 2, 5, 3 }));


            var group2 = (from stud in students
                          where stud.groupNumber == 2
                          select stud).ToList();

            foreach (var item in group2)
            {
                Console.WriteLine("{0} {1}", item.firstname, item.lastname);
            }

            Console.WriteLine("----------");

            var sort = students.OrderBy(x => x.firstname);

            foreach (var item in sort)
            {
                Console.WriteLine("{0} {1}", item.firstname, item.lastname);
            }

            Console.WriteLine("With extension methods---------------------");

            foreach (var item in students.GetGroup2())
            {
                Console.WriteLine("{0} {1}", item.firstname, item.lastname);
            }

            Console.WriteLine("----------");

            foreach (var item in students.OrderByName())
            {
                Console.WriteLine("{0} {1}", item.firstname, item.lastname);
            }

            Console.WriteLine("with abv.bg in Email----------------------");

            var abvEmail = (from stud in students
                            where stud.email.EndsWith("abv.bg")
                            select stud).ToList();

            foreach (var item in abvEmail)
            {
                Console.WriteLine("{0} {1} {2}", item.firstname, item.lastname, item.email);
            }

            Console.WriteLine("Extract by marks(6)--------------------------");

            var byMarks = (from stud in students
                           where stud.marks.Contains(6)
                           select new { stud.fn, stud.marks }).ToList();

            foreach (var item in byMarks)
            {
                Console.WriteLine(item.fn);
            }

            Console.WriteLine("Extract by mark(2)----Extension methood------");

            foreach (var item in students.ByMark())
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("All students marks from 2006-----------------");

            var students06 = (from stud in students
                              where stud.fn[5] == '0' && stud.fn[6] == '6'
                              select stud).ToList();

            foreach (var item in students06)
            {
                Console.WriteLine(item.takeMarks());
            }

            Console.WriteLine("Extract by group number----------------------");

            var byGroup = (from stud in students
                           where stud.groupNumber == 1
                           select stud).ToList();

            foreach (var item in byGroup)
            {
                Console.WriteLine("{0} {1}", item.firstname, item.lastname);
            }

            Console.WriteLine("Extract by group number------Extension--------");

            foreach (var item in students.Bygroup())
            {
                Console.WriteLine("{0} {1}", item.firstname, item.lastname);
            }
        }
    }


    public static class Extensions
    {
        public static List<Student> GetGroup2(this List<Student> collection)
        {
            List<Student> group2 = new List<Student>();

            group2 = (from stud in collection
                      where stud.groupNumber == 2
                      select stud).ToList();

            return group2;
        }

        public static List<Student> OrderByName(this List<Student> collection)
        {
            List<Student> orderedNames = new List<Student>();

            orderedNames = collection.OrderBy(x => x.firstname).ToList();

            return orderedNames;
        }

        public static List<object> ByMark(this List<Student> collection)
        {
            List<object> sorted = new List<object>();

            foreach (var item in collection)
            {
                if (item.marks.Contains(2))
                {
                    int twoMarksCount = 0;
                    for (int i = 0; i < item.marks.Count; i++)
                    {
                        if (item.marks[i] == 2)
                        {
                            twoMarksCount++;
                        }
                    }

                    if (twoMarksCount == 2)
                    {
                        sorted.Add(item.fn);      
                    }
                }
            }   
            return sorted;
        }

        public static List<Student> Bygroup(this List<Student> collection)
        {
            List<Student> newGroup = new List<Student>();

            foreach (var item in collection)
            {
                if (item.groupNumber == 1)
                {
                    newGroup.Add(item);
                }
            }
            return newGroup;
        }
    }
}
