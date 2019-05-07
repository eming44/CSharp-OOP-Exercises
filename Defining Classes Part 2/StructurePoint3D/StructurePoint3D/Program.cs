using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StructurePoint3D
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point 3D--------------------------------------------------(checked)
            //Creating some 3D points--------------------(checked)
            Point3D a = new Point3D(1, 3, 5);
            Point3D b = new Point3D(2, 6, 1);
            Point3D c = new Point3D(5, 7, 9);
            Point3D d = new Point3D(9, 1, 4);
            Point3D e = new Point3D(4, 8, 2);
            Point3D f = new Point3D(3, 1, 7);
            Point3D g = new Point3D(1, 9, 5);

            //Test Distance func-------------------------(checked)
            Console.WriteLine("Distance between 3D points A({0}) & B({1}) = {2:F2}",a.ToString(), b.ToString(), Distance.calDistance(a, b));

            //Test Static start point-------------------(checked)
            Console.WriteLine("Start of the coordinate system, Point O({0})", Point3D.GetPointO.ToString());

            //Test path----------------------------------(checked)
            Path pathOfPoints = new Path();
            pathOfPoints.addToPath(c);
            pathOfPoints.addToPath(d);
            pathOfPoints.addToPath(e);
            pathOfPoints.showPoints();

            //Test Path Storage save---------------------(checked)
            PathStorage.savePoint(f);
            PathStorage.savePoint(g);

            //Test path Storage read---------------------(checked)
            PathStorage.readPoint();

            //Generics--------------------------------------------------(checked)
            //Test without parameter---------------------(checked)
            GenericList<int> list = new GenericList<int>();

            //Test with parameter------------------------(checked)
            GenericList<int> listAlpha = new GenericList<int>(42);

            int elementFirst = 1;
            int elementSecond = 2;
            int elementThird = 3;
            int elementFourth = 4;
            int elementFifth = 5;
            int elementSixth = 6;
            //Test Adding func---------------------------(checked)
            listAlpha.Add(elementSecond);
            listAlpha.Add(elementThird);
            listAlpha.Add(elementFifth);
            listAlpha.Add(elementSixth);
            
            //Test Inserting func------------------------(checked)
            listAlpha.insertAt(elementFirst, 0);
            listAlpha.insertAt(elementFourth, 3);

            //Test Max<T>/Min<T> methods-----------------(checked)
            Console.WriteLine(listAlpha.Max());
            Console.WriteLine(listAlpha.Min());

            //Test Removing func-------------------------(checked)
            listAlpha.removeFirst(4);
         
            //Test Finding func--------------------------(checked)
            listAlpha.findByValue(5);
         
            //Test Clear func----------------------------(checked)
            listAlpha.clearAll();

            //Creating and filling Matix-----------------(checked)
            Matrix<int> matrixAlpha = new Matrix<int>(3,3);
            int numAlpha = 10;
            for (int row = 0; row < matrixAlpha.RowsGet; row++)
            {
                for (int col = 0; col < matrixAlpha.ColsGet; col++)
                {
                    matrixAlpha[row, col] = numAlpha;
                    numAlpha++;
                }
            }

            Matrix<int> matrixBeta = new Matrix<int>(3, 3);
            int numBeta = 0;
            for (int row = 0; row < matrixBeta.RowsGet; row++)
            {
                for (int col = 0; col < matrixBeta.ColsGet; col++)
                {
                    matrixBeta[row, col] = numBeta;
                    numBeta++;
                }
            }

            //Test operator (+)--------------------------
            Matrix<int> matrixAdd = new Matrix<int>(3, 3);
            matrixAdd = matrixAlpha + matrixBeta;

            //Test operator (-)--------------------------
            Matrix<int> matrixSubstract = new Matrix<int>(3, 3);
            matrixSubstract = matrixAlpha - matrixBeta;

            //Test operator (*) for 2 matrices-----------
            Matrix<int> matrixMultiply = new Matrix<int>(9, 9);
            matrixMultiply = matrixAlpha * matrixBeta;

            //Test operator (*) overload 1 matrix & 1 number---
            Matrix<int> matrixMultiOverLoad = new Matrix<int>(3, 3);
            int num = 2;
            matrixMultiOverLoad = matrixAlpha;
            matrixMultiOverLoad *= num;

        }
    }
}
