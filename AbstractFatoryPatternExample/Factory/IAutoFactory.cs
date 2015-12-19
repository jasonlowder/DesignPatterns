using FactoryPatternExample.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternExample
{
    public interface IAutoFactory
    {
        // Could pass a paramater to help the factory figure out which object to create
        //IAuto CreateCar(object param);

        IAuto CreateSportsCar();
        IAuto CreateLuxuryCar();
        IAuto CreateEconomyCar();
    }
}
