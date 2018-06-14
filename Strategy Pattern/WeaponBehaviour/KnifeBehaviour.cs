using System;

namespace Strategy_Pattern
{
    public class KnifeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon() => Console.WriteLine("Stabbing with the knife!");
    }
}
