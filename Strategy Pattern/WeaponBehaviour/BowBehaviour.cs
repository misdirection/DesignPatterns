using System;

namespace Strategy_Pattern
{
    public class BowBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shooting an arrow!");
        }
    }
}
