namespace StrategyRework
{
    internal class Peasant : IUnit
    {
        public int MaxHealth { get; set; }

        public int Health { get; set; }
        public string Name { get; set; }
        public Peasant(string name, int health)
        {
            Name = name;
            Health = health;
            MaxHealth = health;
        }

        public event IUnit.ShowInfoDelegate ShowInfoEvent;

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void ShowInfo()
        {
            ShowInfoEvent(Name, Health, null, null, null);
        }
    }
}
