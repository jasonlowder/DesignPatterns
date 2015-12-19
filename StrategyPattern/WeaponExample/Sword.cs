using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.WeaponExample
{
    public class Sword : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using a Sword!");
        }
    }
}
