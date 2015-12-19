using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternExample
{
    public interface IFormatter
    {
        string Format(string key, string value);
    }
}
