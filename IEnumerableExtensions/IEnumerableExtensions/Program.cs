﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();
            numbers.Add(5.3);
            numbers.Add(4);
            numbers.Add(1.2);
            numbers.Add(8);
            numbers.Add(2);

            Console.WriteLine(numbers.GetSum());
            Console.WriteLine(numbers.GetProduct());
            Console.WriteLine(numbers.GetMin());
            Console.WriteLine(numbers.GetMax());
            Console.WriteLine(numbers.GetAverage());
        }
    }

    public static class IEnumerableExtensions
    {
        public static T GetSum<T> (this IEnumerable<T> collection)
        {
            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T GetProduct<T> (this IEnumerable<T> collection)
        {
            dynamic product = 1;

            foreach (var item in collection)
            {
                product *= item;
            }

            return product;
        }

        public static T GetMin<T> (this IEnumerable<T> collection)
        {
            dynamic min = collection.First();

            foreach (var item in collection)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T GetMax<T> (this IEnumerable<T> collection)
        {
            dynamic max = collection.First();

            foreach (var item in collection)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T GetAverage<T> (this IEnumerable<T> collection)
        {
            dynamic average = 0;

            foreach (var item in collection)
            {
                average += item;   
            }
            average /= collection.Count();

            return average;
        }
    }
}
