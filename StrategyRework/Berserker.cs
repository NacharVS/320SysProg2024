using static StrategyRework.IUnit;

namespace StrategyRework
{
    internal class Berserker : IMilitryUnit
    {
        public event ShowInfoDelegate ShowInfoEvent;
        public int _work;
        public int currentDamage;
        public int currentMaxDamage;
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
                if (Health <= MaxHealth / 2)
                {
                    _work++;
                    Rage();
                }
                if (Health > MaxHealth / 2)
                {
                    _work = 0;
                    Rage();
                }
            }
        }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public int MaxDamage { get; set; }
        public int Armor { get; set; }
        public int LvlUpArmor { get; set; }
        public int LvlUpDamage { get; set; }
        public Berserker(string name, int health, int damage, int maxDamage, int armor, int lvlUpArmor, int lvlUpDamage)
        {
            Name = name;
            Health = health;
            MaxHealth = health;
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
            ShowInfoEvent.Invoke(Name,Health,null,Damage,MaxDamage);
        }
        public void Attack(IUnit unit)
        {
            unit.TakeDamage(Damage);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        public void Rage()
        {
            if (_work == 0)
            {
                Damage *= 2;
                MaxDamage *= 2;
            }
            else if (_work == 1)
            {
                Damage = currentDamage;
                MaxDamage = currentMaxDamage;
            }
        }

    }
}
