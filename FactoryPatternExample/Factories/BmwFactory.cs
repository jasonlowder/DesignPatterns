using FactoryPatternExample.Autos;

namespace FactoryPatternExample.Factories
{
    public class BmwFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new BMW335Xi();
        }
    }
}
