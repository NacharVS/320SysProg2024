using static StrategyRework.IUnit;

namespace StrategyRework
{
    internal class Berserker : IMilitryUnit
    {
        public int DamageTest {  get; set; }
        public event ShowInfoDelegate ShowInfoEvent;
        public int _work = 0;
        public int currentDamage;
        public int currentMaxDamage;
        public bool Active {  get; set; }
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
                if (_health <= MaxHealth / 2)
                {
                    _work++;
                    Rage();
                }
                if (_health > MaxHealth / 2)
                {
                    _work = 0;
                    Rage();
                }
            }
        }
        public int _health { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public int MaxDamage { get; set; }
        public int Armor { get; set; }
        public int LvlUpArmor { get; set; }
        public int LvlUpDamage { get; set; }
        public Berserker(string name, int health, int damage, int maxDamage, int armor, int lvlUpArmor, int lvlUpDamage)
        {
            Active = true;
            Name = name;
            _health = health;
            MaxHealth = _health;
            Damage = damage;
            MaxDamage = maxDamage;
            Armor = armor;
            LvlUpArmor = lvlUpArmor;
            LvlUpDamage = lvlUpDamage;
            currentDamage = Damage;
            currentMaxDamage = MaxDamage;
        }
        public void ShowInfo()
        {
            ShowInfoEvent.Invoke(Name, _health, null,Damage,MaxDamage);
        }
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
        public void Rage()
        {
            if (_work == 1)
            {
                Damage *= 2;
                MaxDamage *= 2;
            }
            else if (_work == 0)
            {
                Damage = currentDamage;
                MaxDamage = currentMaxDamage;
            }
        }

    }
}
