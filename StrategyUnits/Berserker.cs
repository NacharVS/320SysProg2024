using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Berserker : MilitaryUnit
    {
        public int _work = 0;
        public int currentDamage;
        public int currentMaxDamage;
        public Berserker(int health, string? name, bool active, int damage, int maxDamage, int armors, int lvlappArmor, int lvlappAttack) : base(health, name, active, damage, maxDamage, armors, lvlappArmor, lvlappArmor)
        {
            currentDamage = damage;
            currentMaxDamage = maxDamage;
        }

        public override int Health
        {
            get => _health;
            set
            {
                if (value < 0)
                    _health = 0;
                else
                    if (value > _maxHealth)
                    _health = _maxHealth;
                else
                    _health = value;
                if (_health <= _maxHealth / 2)
                {
                    _work++;
                    Rage();
                }
                if (_health > _maxHealth / 2)
                {
                    _work = 0;
                    Rage();
                }
            }
        }
        public void Rage()
        {
            if (_work == 1)
            {
                _damage *= 2;
                MaxDamage *= 2;
            }
            else if (_work == 0)
            {
                _damage = currentDamage;
                MaxDamage = currentMaxDamage;
            }
        }
    }
}
