using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.WeaponExample
{
    public class Character
    {
        IWeapon weapon;

        public void SetWeapon(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Attack()
        {
            weapon.Use();
        }
    }
}
