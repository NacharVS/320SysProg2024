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

        public Footman(int Damage, int Health) : base (Damage, "Footman",Health)
        {
            _damage = Damage;
            _health = Health;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Damage: {_damage}");
        }
    } 
}
