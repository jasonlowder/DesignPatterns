﻿using DecoratorPatternExample.Objects.Component;
using DecoratorPatternExample.Objects.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample.Objects.ConcreteDecorators
{
    public class Ham : PizzaDecorator
    {
        public Ham(Pizza pizza) : base(pizza)
        {
            Description = "Ham";
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", _pizza.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.00;
        }
    }
}
