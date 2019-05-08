using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public struct Rectangle : IShape, IMovable, IResizable
    {
        private int x;
        private int y;
        private int width;
        private int height;


        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateSurface()
        {
            return width * height;
        }

        public void Move(int deltax, int deltaY)
        {
            this.x += deltax;
            this.y += deltaY;
        }

        public void Resize(int weightX, int weightY)
        {
            width = width * weightX;
            height = height * weightY;
        }

        public void ResizeByX(int weightX)
        {
            width = width * weightX;
        }

        public void ResizeByY(int weightY)
        {
            height = height * weightY;
        }
    }
}
