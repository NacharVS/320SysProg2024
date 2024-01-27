namespace StrategyRework
{
    internal class Paladin : IMagicUnit, IMilitryUnit, IBattleMagic
    {
        public int _work = 0;
        public int _armor;

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
                {
                    if (value > MaxHealth)
                        Health = MaxHealth;
                    else
                        Health = value;
                }
                if (Health < MaxHealth / 2)
                {
                    _work++;
                    HolyArmor();
                }
                else
                {
                    _work = 0;
                    HolyArmor();
                }

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
        public Paladin(string name, int health, int mana, int damage, int maxDamage, int armor, int lvlUpArmor, int lvlUpDamage)
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
            _armor = armor;
        }
        public void ShowInfo()
        {
            ShowInfoEvent.Invoke(Name,Health,Mana,Damage,MaxDamage);
        }
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
        public void HolyArmor()
        {
            if (_work == 1)
                Armor *= 2;
            else if (_work == 0)
                Armor = _armor;
        }
    }
}
