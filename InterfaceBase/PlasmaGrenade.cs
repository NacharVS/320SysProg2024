using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal class PlasmaGrenade : IWeapon, IExplosiveWeapon
    {
        public double Damage => 12;
        public double Range => 130;

        public void Explosion()
        {
            Console.WriteLine($"Бум. Плазменная граната взорвалась. Диапазон данного оружия = {Range}"); 
        }

    }
}
