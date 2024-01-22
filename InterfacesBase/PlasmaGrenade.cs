using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class PlasmaGrenade : IWeapon, IExplosiveWeapon, IEnergyWeapon
    {
        public int Damage => 100;

        public int Radius => 50;

        public int Energy => 50;

        public void EnergyShoot()
        {
            Console.WriteLine($"Surge {Energy} energy");
        }

        public void Explosion()
        {
            Console.WriteLine($"BOOM! Granade! Radius {50}");
        }
    }
}
