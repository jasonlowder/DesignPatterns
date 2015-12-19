using NullPatternExample.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullPatternExample
{
    public class AutoRepository
    {
        public AutomobileBase Find(string carName)
        {
            if (carName.Contains("mini"))
            {
                return new MiniCooper();
            }

            return AutomobileBase.NULL;
        }
    }
}
