using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Accessibility
{
    class Mammal : Creature
    {
        public int Age
        {
            get;
            set;
        }

        public Mammal(string name, int age) : base(name)
        {
            this.Age = age;
        }

        public void Sleep()
        {
            Console.WriteLine("Shhh! {0} is sleeping!", this.Name);
        }
    }
}
