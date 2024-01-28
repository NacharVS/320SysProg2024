using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZealotKnight : Unit, IBattleUnit, IArmoredUnit, IMagicUnit
    {
        private int _mana;
        public ZealotKnight(string? name, int health, int minDamage, int maxDamage, int shield, int maxMana) : base(name, health)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Armor = shield;
            MaxMana = maxMana;
            _mana = maxMana;
        }

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Armor { get; set; }
        public int ExtraArmor { get; set; }
        public int LevelExtraArmor { get; set; }
        
        public int Mana
        {
            get => _mana;
            set
            {
                if (value < 0)
                    _mana = 0;
                else if (value > MaxMana)
                    _mana = MaxMana;
                else
                    _mana = value;
            }
        }
        public int MaxMana { get; set; }

        public void Attack(Unit unit)
        {
            Random random = new Random();
            int damage = random.Next(MinDamage + IBattleUnit.ExtraDamage, MaxDamage + IBattleUnit.ExtraDamage + 1);
            if (unit is IArmoredUnit armoredUnit)
            {
                Console.WriteLine($"\n{unit.Name} - Shield: {armoredUnit.Armor + IArmoredUnit.ExtraArmor}");
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
        }

        public void Prayer()
        {
            if (Health == MaxHealth)
            {
                Console.WriteLine($"{Name} имеет полное здоровье");
            }
            else if (Mana >= 10)
            {
                Console.WriteLine($"{Name} помолился");
                Health += 20;
                Mana -= 10;
            }
            else
            {
                Console.WriteLine("Недостаточно маны для молитвы");
            }
            
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} - Health: {Health}/{MaxHealth}, Armor: {Armor + IArmoredUnit.ExtraArmor}, Mana: {Mana}, Damage: {MinDamage + IBattleUnit.ExtraDamage}-{MaxDamage + IBattleUnit.ExtraDamage}");
        }
    }
}