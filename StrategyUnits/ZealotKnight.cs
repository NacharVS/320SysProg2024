using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZealotKnight : MagicUnit
    {
        public string? _Name;
        public int _damage;
        public int _health;
        public int _mana;
        public ZealotKnight(string? name, int damage, int health, int mana) : base(damage, name, health, mana)
        {
            _Name = name;
            _damage = damage;
            _health = health;
            _mana = mana;
        }
        public void Prayer()
        {
            if(_mana >= 10)
            {
                Console.WriteLine("Помолимся)");
                CurentHealth += 20;
                _mana -= 10;
                Console.WriteLine($"Текущее количество маны: {Mana}. Текущее здоровье: {CurentHealth}");
            }
            else
            {
                Console.WriteLine("Недостаточно маны чтобы излечиться");
            }
        }
    }
}
