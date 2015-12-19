using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPatternExample
{
    public class Sandwich : Expression
    {
        private readonly Bread topBread;
        private readonly CondimentList topCondiments;
        private readonly IngredientList ingredients;
        private readonly CondimentList bottomCondiments;
        private readonly Bread bottomBread;

        public Sandwich(Bread topBread, CondimentList topCondiments, IngredientList ingredients, CondimentList bottomCondiments, Bread bottomBread)
        {
            this.topBread = topBread;
            this.topCondiments = topCondiments;
            this.ingredients = ingredients;
            this.bottomCondiments = bottomCondiments;
            this.bottomBread = bottomBread;
        }

        public void Interpret(Context context)
        {
            context.Output += "|";
            topBread.Interpret(context);
            context.Output += "|";
            context.Output += "<--";
            topCondiments.Interpret(context);
            context.Output += "-";
            ingredients.Interpret(context);
            context.Output += "-";
            bottomCondiments.Interpret(context);
            context.Output += "-->";
            context.Output += "|";
            bottomBread.Interpret(context);
            context.Output += "|";
            Console.WriteLine(context.Output);
        }
    }
}
