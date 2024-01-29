using StrategyUnits.Interfase;
using System.Xml.Linq;
using static StrategyUnits.Interfase.IAttack;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Footman : Unit, IArmor, IAttack
    {
        public Footman(int health, string? name, int defense, int damage, int ArmorLvl, int WeaponLvl) : base(health, name)
        {
            _defense = defense;
            _damage = damage;
            _ArmorLvl = ArmorLvl;
            _WeaponLvl = WeaponLvl;
        }

        private int _defense;
        public int Defense
        {
            get => IArmor.ArmorLvl * 2 + _defense;
            set => _defense = value;
        }

        private int _ArmorLvl = 1;
        public int ArmorLvl
        {
            get { return _ArmorLvl; }
            set { _ArmorLvl = value; }
        }

        private int _WeaponLvl = 1;
        public int WeaponLvl
        {
            get { return _WeaponLvl; }
            set { _WeaponLvl = value; }
        }
        private int _damage;
        public int Damage
        {
            get => IAttack.WeaponLvl * 2 + _damage;
            set => _damage = value;
        }
        public override void TakeDamage(int damage)
        {
            Health -= damage - Defense;
        }

        public event InflictDamageSmbd InflictDamageSmbdEvent;
        public void InflictDamage(IHealth unit)
        {
            if (Alive == false)
            {
                Console.WriteLine($"{Name} не может продолжать битву, он уже мертв");
                return;
            }
            if (unit.Alive)
            {
                unit.TakeDamage(Damage);
                InflictDamageSmbdEvent.Invoke(Name, Damage);
            }
            else
                Console.WriteLine($"{Name} не может атаковать противника. Противник уже мертв.");
        }
       
        public override void ShowInfo()
        {
            if (Alive)
                Console.WriteLine($"Персонаж: {Name} Здоровье: {Health} Защита: {Defense} Урон: {Damage}");
            else
                Console.WriteLine($"{Name} мертв");
        }

    }
}
