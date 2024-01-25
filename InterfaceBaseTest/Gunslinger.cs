namespace InterfaceBaseTest
{
    internal class Gunslinger
    {
        public static void SingleShoot(IRangeWeapon weapon)
        {
            weapon.Shoot();
        }

        public static void MultiShoot(IAutomaticWeapon weapon)
        {
            weapon.BurstShoot();
        }
    }
}
