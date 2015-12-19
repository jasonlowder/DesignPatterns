using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.AnimalExample
{
    public interface Flies
    {
        string Fly();
    }

    public class ItFlies : Flies
    {

        public string Fly()
        {
            return "Flying high";
        }
    }

    public class CantFlies : Flies
    {

        public string Fly()
        {
            return "I can't fly";
        }
    }
}
