using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structs
{
    struct Point2D
    {
        private int X;
        private int Y;

        public int XGet
        {
            get
            {
                return this.X;
            }
        }

        public int YGet
        {
            get
            {
                return this.Y;
            }
        }

        public Point2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    struct Vector2D
    {
        private int X;
        private int Y;

        public int XGet
        {
            get
            {
                return this.X;
            }
        }

        public int YGet
        {
            get
            {
                return this.Y;
            }
        }

        public Vector2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Point2D operator +(Point2D point, Vector2D vector)
        {
            return new Point2D(point.XGet + vector.X, point.YGet + vector.Y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point2D startPoint = new Point2D(0, 0);

            Vector2D jumpvector = new Vector2D(5, 1);

            Point2D positionAfterJump = startPoint + jumpvector;
            
            Console.WriteLine(positionAfterJump.XGet + " " + positionAfterJump.YGet);
        }
    }
}
