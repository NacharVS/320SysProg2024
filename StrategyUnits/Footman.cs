namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman(int health, string? name, int damage, int guard) : base(health, name, damage, guard)
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
