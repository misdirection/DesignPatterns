namespace Strategy_Pattern
{
    public class Archer : Person
    {
        public Archer(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour)
        {
        }
    }
}
