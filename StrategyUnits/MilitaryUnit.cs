using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _attack;
        private string _name;
        private int _health;
        public int Attack
        {  get => _attack; set { _attack = value; } }
        public int Health
        {  get => _health; set { _health = value; } }
        public MilitaryUnit(int Damage, string Name, int health) : base(health, Name)
        {
            _attack = Damage;
            _name = Name;
            _health = health;
        }
        public void InflictDamage(Unit unit)
        {
            unit.Health -= _attack;
        }
    }
}
