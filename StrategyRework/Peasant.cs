namespace StrategyRework
{
    internal class Peasant : IUnit
    {
        public int MaxHealth { get; set; }
        public bool Active { get; set; }
        public int Health
        {
            get => _health;
            set
            {
                if (value < 0)
                    _health = 0;
                else
                    if (value > MaxHealth)
                    _health = MaxHealth;
                else
                    _health = value;
            }
        }
        public string Name { get; set; }
        public int _health { get; set; }

        public Peasant(string name, int health)
        {
            Active = true;
            Name = name;
            _health = health;
            MaxHealth = _health;
        }

        public event IUnit.ShowInfoDelegate ShowInfoEvent;

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void ShowInfo()
        {
            ShowInfoEvent(Name, _health, null, null, null);
        }
    }
}
