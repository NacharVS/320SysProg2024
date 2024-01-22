

namespace StrategyUnits
{
    internal class Cliric : MagicUnit
    {
        public event HealthChangedDelegate HealUnit;

        private int _healthValue;

        public Cliric(int health, string? name, bool active, int damage, int maxDamage, int mana, int armors, int lvlappArmor, int lvlappAttack) : base(health, name, active, damage, maxDamage, mana, armors, lvlappArmor, lvlappAttack)
        {
        }

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
        

      
        public  void HealHealthunit(Unit unit)
        {
            _healthValue = 1;
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
        
    }

}

