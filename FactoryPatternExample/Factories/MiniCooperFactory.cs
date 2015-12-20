using FactoryPatternExample.Autos;

namespace FactoryPatternExample.Factories
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
