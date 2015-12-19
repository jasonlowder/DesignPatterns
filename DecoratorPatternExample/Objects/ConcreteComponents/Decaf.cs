using DecoratorPatternExample.Objects.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample.Objects.ConcreteComponents
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
