using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public interface IShape
    {
        //string GetName;
        void SetPosition(int x, int y);
        double CalculateSurface();

    }
}
