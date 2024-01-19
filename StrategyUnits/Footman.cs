namespace StrategyUnits
{
    internal class Footman : MilitaryUnit 
    {
        private int _damage;
        private int _health;
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public Footman( int Health, string?  Name, int Damage) : base (Damage, Name, Health)
        {
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine();
        }
    } 
}
