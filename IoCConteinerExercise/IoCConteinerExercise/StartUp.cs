using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Unity;

namespace IoCConteinerExercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //First we need to create a conteiner instance
            //IUnityContainer conteiner = new UnityContainer();

            //Register
            //conteiner.RegisterType<ICar, BMW>();

            //Resolve
            //Driver drv = conteiner.Resolve<Driver>();
            //drv.RunCar();

            IDriver BMWDriver = DriverFactory.CreateCarDriver(CarFactory.CreateBMW());
            BMWDriver.YearsOld = 24;
            BMWDriver.ExperienceYears = 3;
            BMWDriver.ProfessionalDriver = false;

            IDriver audiDriver = DriverFactory.CreateCarDriver(CarFactory.CreateAudi());
            audiDriver.YearsOld = 27;
            audiDriver.ExperienceYears = 7;
            audiDriver.ProfessionalDriver = true;

            IDriver planeDriver = DriverFactory.CreatePlaneDriver(PlaneFactory.CreatePlane());
            planeDriver.YearsOld = 23;
            planeDriver.ExperienceYears = 1;
            planeDriver.ProfessionalDriver = false;

            IDriver F16Driver = DriverFactory.CreatePlaneDriver(PlaneFactory.CreateF_16Raptor());
            F16Driver.YearsOld = 30;
            F16Driver.ExperienceYears = 9;
            F16Driver.ProfessionalDriver = true;
        }
    }
}
