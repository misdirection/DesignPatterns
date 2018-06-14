namespace Strategy_Pattern
{
    public class Bowman : Person
    {
        public Bowman(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour)
        {
        }
    }
}
