using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class SwordBehaviour : IWeaponBehaviour
    {
        public void UseWeapon() => Console.WriteLine("Swinging the sword!");
    }
}
