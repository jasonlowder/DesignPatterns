using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.AnimalExample
{
    public abstract class Animal
    {
        private int weight;

        public string Name { get; set; }
        public double Height { get; set; }
        public int Weight
        {
            get { return weight; }
            set
            {
                if (value > 0) weight = value;
                else Console.WriteLine("Weight must be greater than 0");
            }
        }
        public string FavoriteFood { get; set; }
        public double Speed { get; set; }
        public string Sound { get; set; }
        public Flies FlyingType { private get; set; }

        public string TryToFly()
        {
            return FlyingType.Fly();
        }
    }
}
