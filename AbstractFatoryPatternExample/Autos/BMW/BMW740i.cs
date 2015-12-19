using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Autos.BMW
{
    public class BMW740i : BmwBase
    {
        public BMW740i()
        {
            SetName("BMW 740i");
        }

        public override void TurnOn()
        {
            Console.WriteLine("The {0} is on and running.", Name);
        }

        public override void TurnOff()
        {
            Console.WriteLine("The {0} is off.", Name);
        }
    }
}
