using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructurePoint3D
{
    class Path
    {
        List<Point3D> pathOfPoints = new List<Point3D>();

        public void addToPath(Point3D point)
        {
            pathOfPoints.Add(point);
        }
        
        public void showPoints()
        {
            Console.WriteLine("Points in path:");
            foreach (var item in pathOfPoints)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
