namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        
        public int _damage;
        public int Damage
        {
            get => _damage;
            set { _damage = value; }
        }
        
        public Footman(int health, string? name, int damage) : base(health, name, damage)
        {
            Damage = damage;
        }

       
    }
}
