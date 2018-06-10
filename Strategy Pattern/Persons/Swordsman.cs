using System;

namespace Strategy_Pattern
{
    public class Swordsman : Person
    {
        public Swordsman(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour)
        {
        }
    }
}
