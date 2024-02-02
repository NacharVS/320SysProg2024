namespace StrategyUnits
{
    internal class Footman : Unit, IBattleUnit, IArmoredUnit
    {
        public Footman(string? name, int health, int minDamage, int maxDamage, int shield) : base(name, health)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Armor = shield;
        }

        public virtual int MinDamage { get; set; }
        public virtual int MaxDamage { get; set; }
        public int Armor { get; set; }

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

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} - Health: {Health}/{MaxHealth}, Armor: {Armor + IArmoredUnit.ExtraArmor}, Damage: {MinDamage + IBattleUnit.ExtraDamage}-{MaxDamage + IBattleUnit.ExtraDamage}");
        }
    }
}
