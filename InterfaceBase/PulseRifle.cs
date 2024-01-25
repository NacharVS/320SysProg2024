using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal class PulseRifle : IWeapon, IEnergyWeapon
    {
        public double Damage => 13;
        public double DamageEnergy => 13;

        public void EnergyDamage()
        {
            Console.WriteLine($"Произошел выстрел из импульсивной винтовки. Урон = {Damage}, урон энергии = {DamageEnergy}");
        }
    }
}
