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

        public override double Health
        {
            get => base.Health;
            set
            {
                double previousHealth = base.Health;

                if (value <= 0)
                {
                    base.Health = 0;
                    DiedUnit = true;
                }
                else
                {
                    if (value > MaxHealth)
                        base.Health = MaxHealth;
                    else
                        base.Health = value;
                }

                if (base.Health < MaxHealth * 0.5 && !_rage)
                {
                    PowerRage();
                }
                else if (base.Health >= MaxHealth * 0.5 && _rage)
                {
                    _rage = false;
                    Damage /= 1.5;
                    Console.WriteLine($"У {Name} сверх ярость больше неактивна!");
                }
            }
        }

        public void PowerRage()
        {
            Damage *= 1.5;
            _rage = true;
            Console.WriteLine($"{Name} активировал сверх ярость!");
        }

        public Berserker(string? name,double health,  double damage, double defence) : base(name,health,  damage, defence)
        {

        }
        
    }
}
