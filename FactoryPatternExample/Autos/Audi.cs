using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternExample.Autos
{
    public class Audi : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("The Audi TTS is running, but there is an electrical fire.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The Audi TTS is turned off, but the dashboard is still smoking.");
        }
    }
}
