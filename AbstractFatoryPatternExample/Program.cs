using FactoryPatternExample;
using FactoryPatternExample.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFatoryPatternExample
{
    class Program
    {
        static void Main()
        {
            IAutoFactory factory = LoadFactory();

            PrintHeader("SPORTS CAR");
            var car = factory.CreateSportsCar();
            car.TurnOn();
            car.TurnOff();


            PrintHeader("LUXURY CAR");
            car = factory.CreateLuxuryCar();
            car.TurnOn();
            car.TurnOff();


            PrintHeader("ECONOMY CAR");
            car = factory.CreateEconomyCar();
            car.TurnOn();
            car.TurnOff();

            Console.ReadKey();
        }

        private static void PrintHeader(string carType)
        {
            Console.WriteLine("+++++++++++++++++++++{0}+++++++++++++++++++++", carType);
        }

        static IAutoFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.AutoFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}
