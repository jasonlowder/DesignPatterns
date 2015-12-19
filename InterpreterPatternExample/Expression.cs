using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPatternExample
{
    public interface Expression
    {
        void Interpret(Context context);
    }
}
