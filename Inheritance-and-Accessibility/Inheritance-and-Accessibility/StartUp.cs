using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Accessibility
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dog joe = new Dog("Sharo", 6, "labrador");
            joe.Sleep();
            Console.WriteLine("Breed: {0}", joe.Breed);
            joe.WagTail();
        }
    }
}
