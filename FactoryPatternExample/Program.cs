using FactoryPatternExample.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main()//string[] args)
        {
            //string carName = args[0];

            //AutoFactory factory = new AutoFactory();

            //IAuto car = factory.CreateInstance(carName);
            //IAuto car = GetCar(carName);

            IAutoFactory autoFactory = LoadFactory();

            IAuto car = autoFactory.CreateAutomobile();

            car.TurnOn();
            car.TurnOff();

            Console.ReadKey();
        }

        //static IAuto GetCar(string carName)
        //{
        //    switch (carName)
        //    {
        //        case "bmw":
        //            return new BMW335Xi();
        //        case "mini":
        //            return new MiniCooper();
        //        case "audi":
        //            return new Audi();
        //        default:
        //            return new NullCar();
        //    }
        //}

        static IAutoFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.AutoFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}
