using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Bowman : Person
    {
        public Bowman(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour)
        {
        }
    }
}
