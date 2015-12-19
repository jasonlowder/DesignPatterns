using StrategyPattern.WeaponExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Weapon Example");
            IWeapon weapon = null;

            //while (true)
            //{
                Console.WriteLine("Which weapon do you want to use?");
                int weaponNumber = int.Parse(Console.ReadLine());

                switch (weaponNumber)
                {
                    case 1:
                        weapon = new Sword();
                        break;
                    case 2:
                        weapon = new Axe();
                        break;
                    case 3:
                        weapon = new Club();
                        break;
                }

                Character myGuy = new Character();
                myGuy.SetWeapon(weapon);
                myGuy.Attack();
            //}

            Console.WriteLine("Running Animal Example");

            AnimalExample.Animal sparky = new AnimalExample.Dog();
            AnimalExample.Animal tweety = new AnimalExample.Bird();

            Console.WriteLine("Dog: {0}", sparky.TryToFly());
            Console.WriteLine("Bird: {0}", tweety.TryToFly());

            sparky.FlyingType = new AnimalExample.ItFlies();

            Console.WriteLine("Dog: {0}", sparky.TryToFly());

            Console.ReadKey();
        }
    }
}
