using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Autos
{
    public interface IAuto
    {
        string Name { get; }

        void SetName(string Name);
        void TurnOn();
        void TurnOff();
    }
}
