using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var yytCenter = new YytCenter();

            var flight1 = new AirBus321("AC159", yytCenter);
            var flight2 = new Boeing737200("WS203", yytCenter);
            var flight3 = new Embraer190("AC602", yytCenter);

            flight1.Altitude = 1000;
            flight2.Altitude = 2500;
            flight3.Altitude = 6000;

            flight1.Altitude += 1000;

            Console.ReadKey();
        }
    }
}
