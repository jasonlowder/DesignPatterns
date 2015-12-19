using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public class SuperSandwichBuilder : SandwichBuilder
    {
        public override void AddCondimentes()
        {
            throw new NotImplementedException();
        }

        public override void ApplyVegetables()
        {
            throw new NotImplementedException();
        }

        public override void ApplyMeatAndCheese()
        {
            throw new NotImplementedException();
        }

        public override void PrepareBread()
        {
            throw new NotImplementedException();
        }
    }
}
