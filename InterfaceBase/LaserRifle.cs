using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal class LaserRifle : IWeapon, IEnergyWeapon
    {
        public double Damage => 13;
        public double DamageEnergy => 14;
        public void EnergyDamage() 
        {
            Console.WriteLine($"Произошел выстрел из лазерной винтовки.Урон = { Damage}, урон энергии = { DamageEnergy }");
        }
    }
}
