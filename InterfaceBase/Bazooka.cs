using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal class Bazooka : IWeapon, IExplosiveWeapon
    {
        public double Damage => 10;
        public double Endurance
        {
            get => 30;
            set
            {
                if (Endurance <= 0)
                {
                    Endurance = 0;
                    IsBroke = true;
                }
                else
                    Endurance = value;
            }
        }
        bool IsBroke = false;
        public bool IsBroken
        {
            get { return IsBroke; }
            set { IsBroke = value; }
        }

        public void Explosion()
        {
            Console.WriteLine($"Вы выстрелили из базуки. Урон = {Damage}");
        }

    }
}
