using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPatternExample
{
    public interface IMemento
    {
        // use of object means that the calling code has no knowledge of object type
        object State { get; set; }
    }
}
