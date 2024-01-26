using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        private bool _rage = false;
        public bool Rage
        {
            get { return _rage; }
            set { _rage = value; }
        }

        //public override double Health
        //{
        //    get => base.Health;
        //    set
        //    {
        //        if (value <= 0)
        //        {
        //            base.Health = 0;
        //            DiedUnit = true;
        //        }
        //        else
        //        {
        //            if (value > MaxHealth)
        //                base.Health = MaxHealth;
        //            else
        //                base.Health = value;
        //        }

        //        if (_rage == false && base.Health < MaxHealth * 0.5)
        //        {
        //            PowerRage();
        //        }
        //        else if (_rage == true && base.Health >= MaxHealth * 0.5)
        //        {
        //            DeactivationRage();
        //        }
        //    }
        //}

        //public void PowerRage()
        //{
        //    Damage *= 1.5;
        //    _rage = true;
        //    Console.WriteLine($"{Name} активировал сверх ярость!");
        //}

        //public void DeactivationRage()
        //{
        //     _rage = false;
        //     Damage /= 1.5;
        //     Console.WriteLine($"У {Name} сверх ярость больше неактивна!");
        //}

        
        
    }
}
