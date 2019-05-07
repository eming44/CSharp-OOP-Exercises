using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StructurePoint3D
{
    static class PathStorage
    {
        public static void savePoint(Point3D point)
        {
            using (var stream = new StreamWriter("pathStorage.txt", true))
            {
                stream.WriteLine(point.ToString());
                Console.WriteLine("Point({0}) successfully saved!", point.ToString());
            }
        }

        public static void readPoint()
        {
            using (var stream = new StreamReader("pathStorage.txt"))
            {
                var fileContent = stream.ReadToEnd();
                Console.WriteLine("Paths in file: ");
                Console.WriteLine(fileContent);
            }
        }
    }
}
