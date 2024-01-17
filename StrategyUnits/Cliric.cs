

namespace StrategyUnits
{
    internal class Cliric : MagicUnit
    {
        public event HealthChangedDelegate HealUnit;
        public event HealthChangedDelegate StickCliricAttack;

        private int _healthValue;
        public int Heal
        {
            get { return _healthValue; }
            set { _healthValue = value; }
        }

        public override int Mana
        {
            get => base.Mana;
            set => base.Mana = value;
        }
        public Cliric() : base(80, "Clirc", true, 1, 3, 60)
        {
            _healthValue = 1;
        }

      
        public  void HealHealthunit(Unit unit)
        {
            if (unit == this)
            {
                while (Mana >= 1 && unit.Health < unit._maxHealth)
                {
                    Health += Heal * 2;
                    Mana -= 1;
                    HealUnit.Invoke(unit.Health, unit.Name, Heal, Mana);
                    Console.WriteLine("Клирик вылечил себе здоровье");
                }
            }
            else
            {
                while (Mana >= 2 && unit.Health < unit._maxHealth)
                {
                    unit.Health += Heal;
                    Mana -= 2;
                    HealUnit.Invoke(unit.Health, unit.Name, Heal * 2, Mana);
                    Console.WriteLine($"Клирик вылечил {unit.Name}");
                }
            }
        }
        public override void Attack(Unit unit)
        {
            Random random = new Random();
            Damage = random.Next(_damage, MaxDamage);
            unit.Health -= Damage;
            if (unit.Health == 0)
            {
                unit._active = false;
            }
            Console.WriteLine($"{Name} замахнулся своей ПАЛЧИЩЕЙ");
            StickCliricAttack.Invoke(unit.Health, unit.Name, Damage,null);
        }
    }

}

