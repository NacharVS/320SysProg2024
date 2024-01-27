namespace StrategyRework
{
    internal interface IUnit
    {
        public delegate void ShowInfoDelegate(string name,int health,int? mana, int? damage,int? maxDamage);
        public event ShowInfoDelegate ShowInfoEvent;
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }
        public void TakeDamage(int damage);
        public void ShowInfo();
    }
}
