using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        private int _damage;
        private int _mannaDamage;
        private int _manna;
        public int MaxManna { get; private set; }
        public event HealthChangedDelegate HealthChangedPaladin;
        public Paladin() : base(70, "Paladin")
        {
            _mannaDamage = 5;
            _manna = 20;
            MaxManna = _manna;
        }
        public override void Attack(Unit unit)
        {
            if (unit.Alive)
            {
                Random random = new Random();
                _damage = random.Next(7, 10);
                unit.Health -= _damage + _mannaDamage - Manna * 2;
            }
            else
            {
                Console.WriteLine("Unit is dead");
            }
        }
        public override void ShowInfo()
        {
            HealthChangedPaladin.Invoke(Health, Name, Manna, _damage);
        }
    }
}
