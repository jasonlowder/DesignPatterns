using FactoryPatternExample.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternExample
{
    public interface IAutoFactory
    {
        IAuto CreateAutomobile();
    }
}
