using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Paladin : zeelotKnight
    {
        private int ManaCast;
        public HealthChangedDelegate MagicFireBollAttack;
        public int currentArmor;
        public int _work = 0;

        public Paladin(int health, string? name, bool active, int damage, int maxDamage, int mana, int armors, int lvlappArmor, int lvlappAttack) : base(health, name, active, damage, maxDamage, mana, armors, lvlappArmor, lvlappAttack)
        {
            currentArmor = armor;
            ManaCast = 3;
        }

        public override int Mana
        {
            get => base.Mana;
            set => base.Mana = value;
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
                    HolyArmor();
                }
                if (_health > _maxHealth / 2)
                {
                    _work = 0;
                    HolyArmor();
                }
            }
        }

        public void HolyArmor()
        {
            if (_work == 1)
            {
                armor *= 2;
            }
            else
                armor = currentArmor;
        }

        public override void Attack(Unit unit)
        {
            Console.WriteLine($"Урон нашего война на данный момент {_damage}/{MaxDamage}");
            int damage;
            Random random = new Random();
            Damage = random.Next(_damage, MaxDamage);
            damage = Damage - unit.armor;
            if (damage > 0)
            {
                unit.Health -= damage;
                Mana -= ManaCast;
            }
            else
                unit.Health -= 0;
            if (unit.Health == 0)
            {
                unit._active = false;
            }
            MagicFireBollAttack.Invoke(unit.Health, unit.Name, Damage, ManaCast);
        }
    }
}
