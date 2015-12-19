using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Sandwich(Sandwich.BreadType.White, false, Sandwich.CheeseType.Provolone, Sandwich.MeatType.Ham,
            //    false, true, new List<string> { "Pickles", "Olives" }).Display();

            var sandwichMaker = new SandwichMaker(new MySandwichBuilder());
            sandwichMaker.BuildSandwich();

            var sandwich1 = sandwichMaker.GetSandwich();
            sandwich1.Display();

            Console.WriteLine();

            var sandwichMaker2 = new SandwichMaker(new ClubSandwichBuilder());
            sandwichMaker2.BuildSandwich();

            var sandwich2 = sandwichMaker.GetSandwich();
            sandwich2.Display();

            Console.ReadKey();
        }
    }
}
