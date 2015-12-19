using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public class ClubSandwichBuilder : SandwichBuilder
    {
        public override void AddCondimentes()
        {
            sandwich.hasMayo = true;
            sandwich.hasMustard = true;
        }

        public override void ApplyVegetables()
        {
            sandwich.vegetables = new List<string> { "Tomatoes", "Olives", "Lettuce" };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.cheeseType = Sandwich.CheeseType.Swiss;
            sandwich.meatType = Sandwich.MeatType.Turkey;
        }

        public override void PrepareBread()
        {
            sandwich.breadType = Sandwich.BreadType.Wheat;
            sandwich.isToasted = true;
        }
    }
}
