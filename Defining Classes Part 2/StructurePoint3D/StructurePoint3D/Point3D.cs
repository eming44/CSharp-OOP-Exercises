using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructurePoint3D
{
    struct Point3D
    {
        private double x;
        private double y;
        private double z;

        public double xGet
        {
            get
            {
                return this.x;
            }
        }
        public double yGet
        {
            get
            {
                return this.y;
            }
        }
        public double zGet
        {
            get
            {
                return this.z;
            }
        }
        private static readonly Point3D pointO = new Point3D(0, 0, 0);
        public static Point3D GetPointO
        {
            get
            {
                return pointO;
            }
        }
        

        public Point3D(int newX, int newY, int newZ)
        {
            this.x = newX;
            this.y = newY;
            this.z = newZ;
        }

        public override string ToString()
        {
            return "X:" + this.x + " Y:" + this.y + " Z:" + this.z;
        }
    }
}
