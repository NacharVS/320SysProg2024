using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZealotKnight : Unit, IArmoredUnit, IBattleUnit, IMagicUnit
    {
        private int _mana;

        public ZealotKnight(string? name, int maxHealth, int minDamage, int maxDamage, string weapon, int armor, int maxMana) 
            : base(name, maxHealth)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Weapon = weapon;
            Armor = armor;
            MaxMana = maxMana;
            _mana = maxMana;
        }

        public int Armor { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public string Weapon { get; set; }

        public int Mana
        {
            get => _mana;
            set
            {
                if (value > Mana)
                {
                    if (value > MaxMana)
                        value = MaxMana;
                    Console.WriteLine($"{Name} восстановил ману на {value - Mana}. Текущая мана {value}/{MaxMana}");
                }
                else
                {
                    int waste = Mana - value;
                    if (value < 0)
                        value = 0;
                    Console.WriteLine($"{Name} потратил ману {waste}. Текущая мана {value}/{MaxMana}");
                }
                if (value <= 0)
                {
                    _mana = 0;
                    Console.WriteLine($"{Name} истратил всю ману");
                }
                else if (value > MaxMana)
                    _mana = MaxMana;
                else
                    _mana = value;
            }
        }
        public int MaxMana { get; set; }

        public bool Attack(Unit unit)
        {
            if (!Alive)
            {
                Console.WriteLine($"{Name} мертв. Он не может атаковать");
                return false;
            }
            if (!unit.Alive)
            {
                Console.WriteLine($"{unit.Name} мертв. Не нужно больше его атаковать");
                return false;
            }
            Random random = new Random();
            int damage = random.Next(MinDamage + IBattleUnit.ExtraDamage, MaxDamage + IBattleUnit.ExtraDamage + 1);
            Console.Write($"{Name} атаковал {Weapon} {unit.Name} на {damage}. ");
            if (unit is IArmoredUnit armoredUnit)
            {
                Console.Write($"{unit.Name} имеет защиту {armoredUnit.Armor + IArmoredUnit.ExtraArmor}. ");
                damage -= (armoredUnit.Armor + IArmoredUnit.ExtraArmor);
            }
            if (damage > 0)
            {
                Console.WriteLine();
                unit.Health -= damage;
            }
            else
            {
                Console.WriteLine("Защита не пробита");
            }
            return true;
        }

        public void Prayer()
        {
            if (!Alive)
            {
                Console.WriteLine($"{Name} мертв. Он не может молиться");
                return;
            }
            if (Health == MaxHealth)
            {
                Console.WriteLine($"{Name} имеет полное здоровье. Молитва не нужна");
                return;
            }
            if (Mana < 10)
            {
                Console.WriteLine($"{Name} имеет ману {Mana}/{MaxMana}. Для молитвы нужно минимум 10 очка маны");
                return;
            }
            Console.WriteLine($"{Name} помолился");
            Health += 20;
            Mana -= 10;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Юнит: {Name} Здоровье: {Health}/{MaxHealth} " +
                $"Атака {Weapon}: {MinDamage + IBattleUnit.ExtraDamage}-{MaxDamage + IBattleUnit.ExtraDamage} " +
                $"Защита: {Armor + IArmoredUnit.ExtraArmor} Мана: {Mana}/{MaxMana}");
        }
    }
}
