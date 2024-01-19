namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman(int health, string? name, int damage) : base(health, name, damage)
        {
  
        }

        //public void InflictDamage(Unit unit)
        //{
        //    if (DeadPerson == true)
        //        Console.WriteLine("Unit died");
        //    else
        //    unit.Health -= _damage;
        //}

    }
}
