namespace StrategyUnits
{
    internal class Footman : Unit, IBattleUnit, IArmoredUnit
    {
        public Footman(string? name, int maxHealth, int minDamage, int maxDamage, string weapon, int armor) 
            : base(name, maxHealth)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Weapon = weapon;
            Armor = armor;
        }

        public virtual int MinDamage { get; set; }
        public virtual int MaxDamage { get; set; }
        public string Weapon { get; set; }
        public int Armor { get; set; }

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
                return true;
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

        public override void ShowInfo()
        {
            Console.WriteLine($"Юнит: {Name} Здоровье: {Health}/{MaxHealth} " +
                $"Атака {Weapon}: {MinDamage + IBattleUnit.ExtraDamage}-{MaxDamage + IBattleUnit.ExtraDamage} " +
                $"Защита: {Armor + IArmoredUnit.ExtraArmor}");
        }
    }
}
