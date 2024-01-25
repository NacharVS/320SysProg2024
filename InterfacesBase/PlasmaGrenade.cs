using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class PlasmaGrenade : IGrenade, IExplosiveWeapon, IEnergyWeapon
    {
        public int Timer => 5;

        public int ExplosiveDamage => 8;

        public int EnergyDamage => 5;

        public void Throw()
        {
            Console.WriteLine($"Bam! Plasma grenade exploded after {Timer} sec, " +
                $"dealed {ExplosiveDamage} explosive damage and {EnergyDamage} energy damage");
        }
    }
}
