using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.AnimalExample
{
    public class Dog : Animal
    {
        public Dog()
        {
            Sound = "Bark";

            FlyingType = new CantFlies();
        }
    }
}
