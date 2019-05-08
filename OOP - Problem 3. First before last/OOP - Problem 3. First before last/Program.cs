using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Problem_3.First_before_last
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Georgi", "Toshev", 14));
            students.Add(new Student("Ivan", "Dachev", 23));
            students.Add(new Student("Boqn", "Dimitrov", 30));

            //Problem 3. First before Last
            Console.WriteLine("First before Last----------------------");
            var foundStudents = (from stud in students
                                 where string.Compare(stud.firstname, stud.lastname) < 0
                                 select stud).ToList();

            foreach (var item in foundStudents)
            {
                Console.WriteLine("{0} {1}", item.firstname, item.lastname);
            }

            //Problem 4. Age
            Console.WriteLine("Age------------------------------------");

            var foundAge = (from stud in students
                            where stud.age >= 18 && stud.age <= 24
                            select stud).ToList();

            foreach (var item in foundAge)
            {
                Console.WriteLine("{0} {1}/ Age: {2}", item.firstname, item.lastname, item.age);
            }
            //Problem 5. OrderBy() ThenBy()
            Console.WriteLine("OrderBy() ThenBy()---------------------");

            var sort = students.OrderByDescending(x => x.firstname).ThenByDescending(x => x.lastname);

            foreach (var item in sort)
            {
                Console.WriteLine("{0} {1}", item.firstname, item.lastname);
            }
        }
    }
}
