using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class ImpulseRifle : IWeapon, IEnergyWeapon, IExplosiveWeapon
    {
        public int Damage => 6;

        public int EnergyDamage => 7;

        public int ExplosiveDamage => 4;

        public void Shoot()
        {
            Console.WriteLine($"Pau-pau! Impulse rifle dealed damage: {Damage}, " +
                $"energy damage: {EnergyDamage}, explosive damage: {ExplosiveDamage}");
        }
    }
}
