using DecoratorPatternExample.Objects.Component;
using DecoratorPatternExample.Objects.ConcreteComponents;
using DecoratorPatternExample.Objects.ConcreteDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //LargePizza largePizza = new LargePizza();
            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Ham(largePizza);
            largePizza = new Peppers(largePizza);

            //Console.WriteLine(largePizza.Description);
            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine("{0:C2}", largePizza.CalculateCost());

            Console.ReadKey();
            Console.WriteLine();

            Beverage coffee = new Espresso();
            coffee = new Mocha(coffee);
            coffee = new Mocha(coffee);
            coffee = new Whip(coffee);

            Console.WriteLine(coffee.GetDescription());
            Console.WriteLine("{0:C2}", coffee.Cost());

            Console.ReadKey();
        }
    }
}
