using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate bool Predicate<T>(T value);

    class Program
    {
        static IEnumerable<T> Filter<T>(IEnumerable<T> numbers, Predicate<T> predicate)
        {
            var list = new List<T>();

            foreach (var n in numbers)
            {
                if (predicate(n))
                {
                    list.Add(n);
                }
            }
            return list;
        }

        //bad way for delegate--------------------------------
        static bool IsPrime(int value)
        {
            var upperBound = Math.Sqrt(value);
            var isPrime = true;
            var candidate = 2;

            while (candidate <= upperBound && isPrime)
            {
                isPrime = value % candidate != 0;
                candidate++;
            }

            return isPrime;
        }

        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 20, 13, 15, 7, 17, 33, 16 };
            var words = new string[] {"gosho", "kaun", "dinq", "metla"};
            //better way for delegate----------------------------
            var greater = Filter(numbers, delegate(int value)
            {
                return value > 5;
            });

            //var even = Filter(numbers, delegate(int value)
            //{
            //    return value % 2 == 0;
            //});

            //var shortWords = Filter(words, delegate (string w)
            //{
            //    return w.Length <= 4;
            //});

            //Lambda expressions-----------------------------------
            var even = Filter(numbers, value => value % 2 == 0);
            var shortWords = Filter(words, word => word.Length <= 4);  
            var prime = Filter(numbers, IsPrime);

            //Dont do it for long Lambda expressions!!!
            //var prime = Filter(numbers, n =>
            //    {
            //        var upperBound = Math.Sqrt(n);
            //        var isPrime = true;
            //        var candidate = 2;
            //
            //        while (candidate <= upperBound && isPrime)
            //        {
            //            isPrime = n % candidate != 0;
            //            candidate++;
            //        }
            //
            //        return isPrime;
            //    });


            Console.WriteLine(greater.StringJoin());
            Console.WriteLine(even.StringJoin());
            Console.WriteLine(prime.StringJoin());

        }

    }

    public static class GenericExtensions
    {
        public static int ToInt32(this string str)
        {
            return int.Parse(str);
        }

        public static string StringJoin<T>(this IEnumerable<T> elements, string separator = ", ")
        {
            return string.Join(separator, elements);
        }
    }
}
