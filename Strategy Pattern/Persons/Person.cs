/* Abstrakte Basisklasse hat ein Interface Waffenverhalten */


namespace Strategy_Pattern
{
    public abstract class Person
    {
        protected IWeaponBehaviour _weaponBehaviour;

        protected Person(IWeaponBehaviour weaponBehaviour) => _weaponBehaviour = weaponBehaviour;
        public void SetWeapon(IWeaponBehaviour weaponBehaviour) => _weaponBehaviour = weaponBehaviour;
        public void Fight()
        {
            _weaponBehaviour.UseWeapon();
        }
    }
}
