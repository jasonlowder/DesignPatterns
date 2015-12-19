using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.AnimalExample
{
    public class Bird : Animal
    {
        public Bird()
        {   
            Sound = "Tweet";

            FlyingType = new ItFlies();
        }
    }
}
