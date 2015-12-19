using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample.Objects.Component
{
    public abstract class Beverage
    {
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract double Cost();
    }
}
