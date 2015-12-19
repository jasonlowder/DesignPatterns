using DecoratorPatternExample.Objects.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample.Objects.ConcreteComponents
{
    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            Description = "Large Pizza";
            Price = 9.00;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return Price;
        }
    }
}
