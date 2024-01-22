namespace InterfacesBase
{
    internal class Pistol : IWeapon
    {
        public int Damage => 7;

        public void Shoot()
        {
            Console.WriteLine($"piu-piu! dealed {Damage}");
        }
    }
}
