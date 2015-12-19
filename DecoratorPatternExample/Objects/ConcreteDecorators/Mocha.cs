using DecoratorPatternExample.Objects.Component;
using DecoratorPatternExample.Objects.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample.Objects.ConcreteDecorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
            Description = "Mocha";
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", beverage.GetDescription(), Description);
        }

        public override double Cost()
        {
            return beverage.Cost() + .20;
        }
    }
}
