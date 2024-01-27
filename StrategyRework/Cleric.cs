using static System.Net.Mime.MediaTypeNames;

namespace StrategyRework
{
    internal class Cleric : IMagicUnit, IWarrior
    {
        public int HealthValue;

        public event IUnit.ShowInfoDelegate ShowInfoEvent;

        public string Name { get; set; }
        public int Health
        {
            get => Health;
            set
            {
                if (value < 0)
                    Health = 0;
                else
                    if (value > MaxHealth)
                    Health = MaxHealth;
                else
                    Health = value;
            }
        }
        public int MaxHealth { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }
        public int Armor { get; set; }
        public int LvlUpArmor { get; set; }
        public Cleric(string name, int health, int mana, int armor, int lvlUpArmor)
        {
            Name = name;
            Health = health;
            MaxHealth = health;
            Mana = mana;
            MaxMana = mana;
            Armor = armor;
            LvlUpArmor = lvlUpArmor;
            HealthValue = 1;
        }
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        public void Heal(IUnit unit)
        {
            if (unit == this)
            {
                while (Mana >= 1 && unit.Health < unit.MaxHealth)
                {
                    Health += HealthValue * 2;
                    Mana -= 1;
                    //HealUnit.Invoke(unit.Health, unit.Name, Heal, Mana);
                    Console.WriteLine("Клирик вылечил себе здоровье");
                }
            }
            else
            {
                while (Mana >= 2 && unit.Health < unit.MaxHealth)
                {
                    unit.Health += HealthValue;
                    Mana -= 2;
                    //HealUnit.Invoke(unit.Health, unit.Name, Heal * 2, Mana);
                    Console.WriteLine($"Клирик вылечил {unit.Name}");
                }
            }
        }

        public void ShowInfo()
        {
            ShowInfoEvent.Invoke(Name, Health, Mana,null, null);
        }
    }
}
