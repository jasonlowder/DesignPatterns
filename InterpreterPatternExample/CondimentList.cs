using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterpreterPatternExample
{
    public class CondimentList : Expression
    {
        private readonly List<Condiment> condiments;

        public CondimentList(List<Condiment> condiments)
        {
            this.condiments = condiments;
        }

        public void Interpret(Context context)
        {
            foreach (var condiment in condiments)
            {
                condiment.Interpret(context);
            }
        }
    }
}
