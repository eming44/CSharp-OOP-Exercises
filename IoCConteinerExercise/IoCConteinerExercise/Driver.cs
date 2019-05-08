using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCConteinerExercise
{
    public class Driver : IDriver
    {
        private int yearsOld;
        private int experienceYears;
        private bool professionalDriver;

        private ICar _car = null;

        public int YearsOld
        {
            get
            {
                return this.yearsOld;
            }
            set
            {
                this.yearsOld = value;
            }
        }
        public int ExperienceYears
        {
            get
            {
                return this.experienceYears;
            }
            set
            {
                this.experienceYears = value;
            }
        }
        public bool ProfessionalDriver
        {
            get
            {
                return this.professionalDriver;
            }
            set
            {
                this.professionalDriver = value;
            }
        }

        public Driver(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile", _car.GetType().Name, _car.Run());
        }
    }
}
