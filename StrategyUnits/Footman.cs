namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        
        public Footman() : base("Footman", 60, 3)
        {
            
        }

        public override void Attack(Unit unit)
        {
            unit.Health -= Damage;
            Console.WriteLine($"Персонаж {Name} нанес урон персонажу {unit.Name}");
        }


    }
}
