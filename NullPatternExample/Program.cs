using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoRepository = new AutoRepository();

            var automobile = autoRepository.Find("mini cooper");

            automobile.Start();
            automobile.Stop();

            // returns NullAutomobile
            var automobile2 = autoRepository.Find("ford");

            // it is possible to check for null reference
            //if (automobile2 == NullPatternExample.Autos.AutomobileBase.NULL)
            //    return;

            // No need to check for null before executing methods as object does nothing
            automobile2.Start();
            automobile2.Stop();


            Console.ReadKey();
        }
    }
}
