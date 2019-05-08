using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DivisibleBy7And3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 21, 33, 39, 100, 55, 63 };

            var divisible = numbers.Where(x => x % 3 == 0 && x % 7 == 0);

            foreach (var item in divisible)
            {
                Console.WriteLine(item);
            }

            var divisible2 = from num in numbers
                             where num % 3 == 0 && num % 7 == 0
                             select num;


            foreach (var item in divisible2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
