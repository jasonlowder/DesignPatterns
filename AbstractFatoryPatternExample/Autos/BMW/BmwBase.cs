using FactoryPatternExample.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Autos.BMW
{
    public abstract class BmwBase : IAuto
    {
        protected string name;
        public string Name { get { return name; } }

        public void SetName(string Name)
        {
            this.name = Name;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}
