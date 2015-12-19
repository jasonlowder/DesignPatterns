using FactoryPatternExample.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Factory
{
    class MiniCooperFactory : IAutoFactory
    {
        public Autos.IAuto CreateSportsCar()
        {
            var mini = new MiniCooper();
            mini.AddSportsPackage();

            return mini;
        }

        public Autos.IAuto CreateLuxuryCar()
        {
            var mini = new MiniCooper();
            mini.AddLuxuryPackage();

            return mini;
        }

        public Autos.IAuto CreateEconomyCar()
        {
            return new MiniCooper();
        }
    }
}
