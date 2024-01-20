using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        public event HealthChangedDelegate AttackUnit;
        public event HealthChangedDelegate InfoSolderChangeEvent;
        public int _damage;
        public int MaxDamage;
        public int LvlappAttack;
        public MilitaryUnit(int health, string? name, bool active, int damage, int maxDamage, int armors, int lvlappArmor, int lvlappAttack) : base(health, name, active, armors, lvlappArmor)
        {
            _damage = damage;
            MaxDamage = maxDamage;
            LvlappAttack = lvlappAttack;
        }

        public int Damage;
        //{
        //    get { return _damage; }
        //    set { _damage = value; }
        //}

        public virtual void Attack(Unit unit)
        {
            Console.WriteLine($"Урон нашего война на данный момент {_damage}/{MaxDamage}");
            int damage;
            Random random = new Random();
            Damage = random.Next(_damage, MaxDamage);
            damage = Damage - unit.armor;
            if (damage > 0)
                unit.Health -= damage;
            else
                unit.Health -= 0;
            if (unit.Health == 0)
            {
                unit._active = false;
            }
            AttackUnit.Invoke(unit.Health, unit.Name, Damage, null);
        }
        public override void ShowInfo()
        {
            if (!_active)
            {
                InfoSolderChangeEvent.Invoke(_health, Name, 1, _damage);
            }
            else
                InfoSolderChangeEvent.Invoke(_health, Name, 0, _damage);
        }
    }
}
