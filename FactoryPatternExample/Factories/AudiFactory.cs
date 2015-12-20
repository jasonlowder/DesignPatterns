using FactoryPatternExample.Autos;

namespace FactoryPatternExample.Factories
{
    public class AudiFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new Audi();
        }
    }
}
