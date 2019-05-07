using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLecture2
{
    public delegate void Print(string str);
    class Program
    {
        static void PrintStr(string str)
        {
            Console.WriteLine(str);
        }

        static void PrintUpperCase(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        static void PrintGreen(string str)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Main()
        {
            Print printAllThePrinting = PrintStr;
            printAllThePrinting += PrintUpperCase;
            printAllThePrinting += PrintGreen;

            printAllThePrinting("Pesho");

            //honorable mentions
            printAllThePrinting -= PrintGreen;
            printAllThePrinting("Gosho");
            printAllThePrinting("Tosho");
            printAllThePrinting("Stamat");

        }
    }
}
