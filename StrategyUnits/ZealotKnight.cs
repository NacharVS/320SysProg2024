using StrategyUnits.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StrategyUnits.Interfase.IAttack;
using static StrategyUnits.Interfase.IMana;

namespace StrategyUnits
{
    internal class ZealotKnight : Unit, IArmor, IAttack, IMana
    {
        public ZealotKnight(int health, string? name, int defense, int damage, int mana, int ArmorLvl, int WeaponLvl) : base(health, name)
        {
            _defense = defense;
            _damage = damage;
            _ArmorLvl = ArmorLvl;
            _WeaponLvl = WeaponLvl;
        }
        public void RegenerationMana(int mana)
        {
            Mana += mana;
        }
        public void SpendMana(int mana)
        {
            Mana -= mana;
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

        public int _current_mana { get; set; }
        public int _max_mana { get; set; }

        public event RegenerateMana RegenerateManaEvent;
        public event DecreasedMana DecreasedManaEvent;

        public int Mana
        {
            get => _current_mana;
            set
            {
                if (value < 0)
                    _current_mana = 0;
                else
                    if (value > _max_mana)
                    _current_mana = _max_mana;
                else
                    if (value > _max_mana)
                    _current_mana = _max_mana;
                else
                if (_current_mana < value)
                {
                    RegenerateManaEvent.Invoke(Name, _current_mana, value, _max_mana);
                }
                else
                {
                    DecreasedManaEvent.Invoke(Name, _current_mana, value, _max_mana);
                }
                _current_mana = value;
            }
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
                Console.WriteLine($"Персонаж: {Name} Здоровье: {Health} Маны: {Mana} Защита: {Defense} Урон: {Damage}");
            else
                Console.WriteLine($"{Name} мертв");
        }
        public void Prayer(ZealotKnight zealotKnight)
        {
            if (zealotKnight.Alive)
            {
                if (zealotKnight.Health == zealotKnight.MaxHealth)
                {
                    Console.WriteLine($"{zealotKnight.Name} полностью здоров!");
                    return;
                }
                else if (Mana < 10)
                {
                    Console.WriteLine($"У {zealotKnight.Name} недостаточно маны,чтобы вылечить себя");
                    return;
                }
                else
                {
                    if (Mana >= 10 && zealotKnight.Health < zealotKnight.MaxHealth)
                    {
                        Console.WriteLine($"{zealotKnight.Name} вылечили себя на 20 HP");
                        zealotKnight.RestoreHealth(20);
                        zealotKnight.SpendMana(10);
                    }
                }
            }
            else
                Console.WriteLine($"{zealotKnight.Name} не может вылечить себя, он уже мертв");
        }
    }
}
