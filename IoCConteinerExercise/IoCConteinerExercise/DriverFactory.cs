using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Unity;
using Unity.Injection;

namespace IoCConteinerExercise
{
    public class DriverFactory
    {
        public static IDriver CreatePlaneDriver(IPlane plane)
        {
            IUnityContainer conteiner = new UnityContainer();
            conteiner.RegisterType<Driver>(new InjectionConstructor(new object[] { plane }));
            Driver drv = conteiner.Resolve<Driver>();
            return drv;
        }

        public static IDriver CreateCarDriver(ICar car)
        {
            IUnityContainer conteiner = new UnityContainer();
            conteiner.RegisterType<Driver>(new InjectionConstructor(new object[] { car }));
            Driver drv = conteiner.Resolve<Driver>();
            return drv;
        }
    }
}
