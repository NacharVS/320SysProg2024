using StrategyUnits.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Cleric : Unit, IArmor, IAttack, IMana
    {
        public Cleric(int health, string? name,int Mana,int defense, int damage, int ArmorLvl, int WeaponLvl) : base(health, name)
        {
            _current_mana = Mana;
            _max_mana = Mana;
            _defense = defense;
            _damage = damage;
            _ArmorLvl = ArmorLvl;
            _WeaponLvl = WeaponLvl;
        }
        private int _defense;
        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        private int _ArmorLvl = 1;
        public int ArmorLvl
        {
            get { return _ArmorLvl; }
            set { _ArmorLvl = value; }
        }

        private int _WeaponLvl = 1;
        public int WeaponLvl
        {
            get { return _WeaponLvl; }
            set { _WeaponLvl = value; }
        }
        private int _damage;
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        private int _current_mana;
        public int _max_mana { get; set; }

        public int Mana
        {
            get => _current_mana;
            set
            {
                if (value < 0)
                    _current_mana = 0;
                else
                    if (value > _max_mana)
                    _current_mana = _max_mana;
                else
                    _current_mana = value;
            }
        }
        public override void TakeDamage(int damage)
        {
            Health -= damage - Defense;
        }
        public void InflictDamage(IHealth unit)
        {
            if (Alive == false)
            {
                Console.WriteLine($"{Name} не может продолжать битву, он уже мертв");
                return;
            }
            if (unit.Alive)
            {
                unit.TakeDamage(Damage);
            }
            else
                Console.WriteLine($"{Name} не может атаковать противника. Противник уже мертв.");
        }

        public void CureSomebody(Unit unit)
        {
            if (unit.Alive)
            {
                if (unit.Health == MaxHealth)
                {
                    Console.WriteLine($"{Name} полностью здоров");
                    return;
                }

                else if (Mana < 2)
                {
                    Console.WriteLine($"{Name} имеет недостаточно маны для лечения {unit.Name}");
                    return;
                }
                else
                {
                    while (Mana > 0 && unit.Health < unit.MaxHealth)
                    {
                        Console.WriteLine($"{Name} вылечил {unit.Name} на 1 HP.");
                        unit.RestoreHealth(1);
                        SpendMana(2);
                    }
                }
            }
            else
                Console.WriteLine($"Вы не можете вылечить {unit.Name}, его с нами больше нет (╥_╥)");

        }

        public void RegenerationMana()
        {
            if (Alive)
            {
                RegenerationMana(10);
                Console.WriteLine($"Вы восстановили ману. Ваша мана равна {Mana}");
            }
            else
                Console.WriteLine($"{Name} не может восстановить ману,он мертв");
        }

        public override void ShowInfo()
        {
            if (Alive)
                Console.WriteLine($"Персонаж: {Name} Здоровья: {Health} Маны: {Mana} Защита: {Defense} Урон: {Damage}");
            else
                Console.WriteLine($"{Name} мертв ");
        }

        public void RegenerationMana(int mana)
        {
            Mana += mana;
        }

        public void SpendMana(int mana)
        {
            Mana -= mana;
        }
    }
}
