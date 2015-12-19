using DecoratorPatternExample.Objects.Component;
using DecoratorPatternExample.Objects.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample.Objects.ConcreteDecorators
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage)
        {
            Description = "Soy";
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", beverage.GetDescription(), Description);
        }

        public override double Cost()
        {
            return beverage.Cost() + .15;
        }
    }
}
