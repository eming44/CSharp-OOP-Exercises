using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Startup
    {
        static void Main(string[] args)
        {
            Square square = new Square(2, 2, 14);
            Rectangle rectangle = new Rectangle(1, 1, 15, 20);
            Circle circle = new Circle(1, 1, 2);

            if (square is IShape)
            {
                Console.WriteLine("{0} is IShape", circle.GetType());
            }
            if (rectangle is IResizable)
            {
                Console.WriteLine("{0} is IMovealble", circle.GetType());
            }
            if (circle is IResizable)
            {
                Console.WriteLine("{0} is IResizable", circle.GetType());
            }

            IShape[] shapes = { square, rectangle, circle };
            foreach (IShape item in shapes)
            {
                item.SetPosition(5, 5);
                Console.WriteLine("Type: {0}; Surface: {1}", item.GetType(), item.CalculateSurface());
            }
        }
    }
}
