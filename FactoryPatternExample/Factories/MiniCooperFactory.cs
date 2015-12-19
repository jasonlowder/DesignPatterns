using FactoryPatternExample;
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
        public Autos.IAuto CreateAutomobile()
        {
            //var mini = new MiniCooper();
            //mini.SetName("Mini Cooper S");

            //return mini;

            return new MiniCooper();
        }
    }
}
