using FactoryPatternExample;
using FactoryPatternExample.Autos.BMW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFatoryPatternExample.Factory
{
    public class BmwFactory : IAutoFactory
    {
        public FactoryPatternExample.Autos.IAuto CreateSportsCar()
        {
            return new BMWM3();
        }

        public FactoryPatternExample.Autos.IAuto CreateLuxuryCar()
        {
            return new BMW740i();
        }

        public FactoryPatternExample.Autos.IAuto CreateEconomyCar()
        {
            return new BMW328i();
        }
    }
}
