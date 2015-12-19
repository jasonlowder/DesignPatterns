using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPatternExample
{
    class Program
    {
        //BNF :
        //<sandwich> ::= <bread> <condimentList> <ingredientList> <condimentList> <bread>
        //<condimentList> ::= { condiment }
        //<ingredientList> ::= { ingredient }
        //<bread> ::= <whiteBread> | <wheatBread>
        //<condiment> ::= <mayoCondiment> | <mustardCondiment> | <ketchupCondiment>
        //<ingredient> ::= <lettuceIngredient> | <tomatoIngredient> | <chickenIngredient>
        
        static void Main(string[] args)
        {
            Sandwich sandwich = new Sandwich(
                    new WheatBread(),
                    new CondimentList(
                        new List<Condiment> { new MayoCondiment(), new MustardCondiment() }),
                    new IngredientList(
                        new List<Ingredient> { new LettuceIngredient(), new ChickenIngredient() }),
                    new CondimentList(
                        new List<Condiment> { new KetchupCondiment() }),
                    new WheatBread()
                );

            sandwich.Interpret(new Context());

            Console.ReadKey();
        }
    }
}
