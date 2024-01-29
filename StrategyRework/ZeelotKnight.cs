namespace StrategyRework
{
    internal class ZeelotKnight: IMagicUnit, IMilitryUnit,IBattleMagic
    {
        public int DamageTest {  get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
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
        public int MaxHealth { get; set; }
        public int ManaStart { get; set; }
        public int Mana
        {
            get => ManaStart;
            set
            {
                if (value < 0)
                    ManaStart = 0;
                else
                    if (value > MaxMana)
                    ManaStart = MaxMana;
                else
                    ManaStart = value;
            }
        }
        public int MaxMana { get; set; }
        public int Damage { get; set; }
        public int MaxDamage { get; set; }
        public int Armor { get; set; }
        public int LvlUpArmor { get; set; }
        public int LvlUpDamage { get; set; }
        public int _health { get; set; }
        public ZeelotKnight(string name, int health, int mana, int damage, int maxDamage, int armor, int lvlUpArmor, int lvlUpDamage)
        {
            Active = true;
            Name = name;
            _health = health;
            MaxHealth = _health;
            ManaStart = mana;
            MaxMana = ManaStart;
            Damage = damage;
            MaxDamage = maxDamage;
            Armor = armor;
            LvlUpArmor = lvlUpArmor;
            LvlUpDamage = lvlUpDamage;
        }

        public event IUnit.ShowInfoDelegate ShowInfoEvent;

        public void Attack(IWarrior unit)
        {
            Console.WriteLine($"Урон нашего война на данный момент {Damage}/{MaxDamage}");
            int damage;
            Random random = new Random();
            DamageTest = random.Next(Damage, MaxDamage);
            damage = DamageTest - unit.Armor;
            if (damage > 0)
            {
                unit.TakeDamage(damage);
                Mana -= 2;
            }
            else
                unit.Health -= 0;
            if (unit.Health == 0)
            {
                unit.Active = false;
            }
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
            ShowInfoEvent.Invoke(Name, _health, Mana, Damage, MaxDamage);
        }
    }
}
