using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public class MySandwichBuilder : SandwichBuilder
    {
        public override void AddCondimentes()
        {
            sandwich.hasMayo = true;
            sandwich.hasMustard = false;
        }

        public override void ApplyVegetables()
        {
            sandwich.vegetables = new List<string> { "Pickles", "Olives" };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.cheeseType = Sandwich.CheeseType.Provolone;
            sandwich.meatType = Sandwich.MeatType.Ham;
        }

        public override void PrepareBread()
        {
            sandwich.breadType = Sandwich.BreadType.White;
            sandwich.isToasted = false;
        }
    }
}
