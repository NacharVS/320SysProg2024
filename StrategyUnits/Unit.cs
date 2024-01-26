namespace StrategyUnits
{
    internal class Unit : IHealth, IMovingUnit
    {
        
        private string? _name;
        

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool IsDied { get; set; }
        public double Health { get; set; }
        public double MaxHealth { get; set; }

        public void Move()
        {
            Console.WriteLine("Движется");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {_name}");
        }

        public void DecreaseHealth(double damage)
        {
            Health -= damage;
        }

        public void IncreseHealth(double health)
        {
            Health += health;
        }

        //public delegate void HealthChangedDelegate(string? name, double health, double difference);
        //public event HealthChangedDelegate HealthIncreasedEvent;
        //public event HealthChangedDelegate HealthDecreasedEvent;
        
    }
}
