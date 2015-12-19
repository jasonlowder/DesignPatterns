using DecoratorPatternExample.Objects.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample.Objects.ConcreteComponents
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
