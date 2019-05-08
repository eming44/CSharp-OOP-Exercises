using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCConteinerExercise
{
    public class F_16Raptor : IPlane
    {
        private int _miles = 0;

        public int Fly()
        {
            return ++_miles;
        }
        public void MissleAttack()
        {

        }
    }
}
