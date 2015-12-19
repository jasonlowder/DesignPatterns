using DecoratorPatternExample.Objects.Component;
using DecoratorPatternExample.Objects.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample.Objects.ConcreteDecorators
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage)
        {
            Description = "Whip";
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", beverage.GetDescription(), Description);
        }

        public override double Cost()
        {
            return beverage.Cost() + .10;
        }
    }
}
