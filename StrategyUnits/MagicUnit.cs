using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _damage;
        private string _name;
        private int _health;
        public int _mana;
        private int _prevMana;
        public int maxMana;
        public int MaxiMana
        {
            get { return maxMana; }
            set { maxMana = value; }
        }
        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value < 0)
                    _mana = 0;
                else
                    if (value > maxMana)
                    _mana = maxMana;
                else
                    _mana = value;
            }
        }
        public int PrevMana
        { get => _prevMana; set => _prevMana = value; }
        public MagicUnit(int Damage, string Name, int Health, int Mana) : base (Damage, Name, Health)
        {
            _damage = Damage;
            _name = Name;
            _health = Health;
            _mana = Mana;
        }
        virtual public void ToHeal(Unit unit)
        {
            Console.WriteLine("Hilling");
            if (unit.Dead)
            { Console.WriteLine("Dude is dead, oh, no.. We can't heal him("); return; }

            while (_mana > 0)
            {
                if (unit.Health < unit.MaxHealth)
                {
                    if (unit.Name == "Healer")
                    {
                        unit.PrevHealth = unit.Health;
                        _mana -= 1;
                        unit.Health += 2;
                        Console.WriteLine($"SelfHealing from {unit.PrevHealth} to {unit.Health}; Mana: {_mana}");
                        
                    }
                    else
                    {
                        unit.PrevHealth = unit.Health;
                        _mana -= 2;
                        unit.Health += 1;
                        Console.WriteLine($"Healing from {unit.PrevHealth} to {unit.Health}; Mana: {_mana}");
                       
                    }
                }
                if (unit.Health >= unit.MaxHealth)
                {
                    Console.WriteLine("Healed healthy dude");
                    break;
                }
            }
            if (_mana == 0)
                Console.WriteLine("no Mana :( grustno");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"| Mana: {_mana}/{maxMana}");
        }
    }
}
