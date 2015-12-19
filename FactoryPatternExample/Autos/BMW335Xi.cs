using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternExample.Autos
{
    public class BMW335Xi : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("The BMW 335Xi is on and running.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The BMW 335Xi is off.");
        }
    }
}
