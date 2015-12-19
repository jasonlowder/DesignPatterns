using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternExample.Autos
{
    public class NullAuto : IAuto
    {
        public void TurnOn()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get { return string.Empty; }
        }

        public void SetName(string Name) { }
    }
}
