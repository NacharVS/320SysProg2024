using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeaponInterfaces.Interfaces;

namespace TestWeaponInterfaces
{
    internal class PulseRifle : IWeapon, IEnergyWeapon
    {
        public int Damage => 9;

        public void Detonation()
        {
            throw new NotImplementedException();
        }

        public void PulseShoot()
        {
            Console.WriteLine($"Увиииинь. Damage: {Damage}");
        }
        public void ShowGun()
        {
            Console.WriteLine($"Вы осмотрели {this.GetType()}");
        }

    }
}
