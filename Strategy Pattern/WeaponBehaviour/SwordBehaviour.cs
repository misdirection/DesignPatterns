using System;

namespace Strategy_Pattern
{
    public class SwordBehaviour : IWeaponBehaviour
    {
        public void UseWeapon() => Console.WriteLine("Swinging the sword!");
    }
}
