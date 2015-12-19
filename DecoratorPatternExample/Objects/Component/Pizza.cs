using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample.Objects.Component
{
    public abstract class Pizza
    {
        public string Description { get; set; }
        public double Price { get; set; }

        public abstract string GetDescription();

        public abstract double CalculateCost();
    }
}
