namespace StrategyRework
{
    internal class ZeelotKnight: IMagicUnit, IMilitryUnit,IBattleMagic
    {
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
        public int Damage { get; set; }
        public int MaxDamage { get; set; }
        public int Armor { get; set; }
        public int LvlUpArmor { get; set; }
        public int LvlUpDamage { get; set; }
        public ZeelotKnight(string name, int health, int mana, int damage, int maxDamage, int armor, int lvlUpArmor, int lvlUpDamage)
        {
            Name = name;
            Health = health;
            MaxHealth = health;
            Mana = mana;
            MaxMana = mana;
            Damage = damage;
            MaxDamage = maxDamage;
            Armor = armor;
            LvlUpArmor = lvlUpArmor;
            LvlUpDamage = lvlUpDamage;
        }

        public event IUnit.ShowInfoDelegate ShowInfoEvent;

        public void Attack(IUnit unit)
        {
            unit.TakeDamage(Damage);
            Mana -= 2;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        public void Prayer()
        {
            Health += 20;
            Mana -= 10;
        }

        public void ShowInfo()
        {
            ShowInfoEvent.Invoke(Name, Health, Mana, Damage, MaxDamage);
        }
    }
}
