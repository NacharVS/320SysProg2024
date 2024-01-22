namespace InterfacesBase
{
    internal class Machinegun :  IAutomaticWeapon
    {
        public int Damage { get => 4;  }

        public void BurstShoot()
        {
            int totalDamage = 0;
            for (int i = 0; i < 3; i++)
            {
                totalDamage += Damage;
            }
            Console.WriteLine($"Tra-ta-ta! Dealed{totalDamage}");
        }
    }
}
