using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        private int _mana;
        public int maxMana;
        public int MaxiMana
        {
            get { return maxMana; }
            set { maxMana = value; }
        }
        public int Mana
        {
            get { return _mana; }
            set {
                if (value < 0)
                    _mana = 0;
                else 
                    if (value > maxMana)
                        _mana = maxMana; 
                    else
                        _mana = value; }
        }
        public Healer(int Mana, int Health) : base(5, "Healer", Health, Mana)
        {
            _maxHealth = Health;
            _mana = Mana;
            maxMana = Mana;
        }
        public void ToHeal(Unit unit)
        {   Console.WriteLine("Hilling");
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
                        Console.WriteLine($"SelfHealing from {unit.PrevHealth} to {unit.Health}; Mana: {_mana}");
                        unit.Health += 2;
                    }
                    else
                    {
                        unit.PrevHealth = unit.Health;
                        _mana -= 2;
                        Console.WriteLine($"Healing from {unit.Health} to {unit.Health + 1}; Mana: {_mana}");
                        unit.Health += 1;
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
        public override void InflictDamage(Unit unit)
        {
            base.InflictDamage(unit);
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Healer's Mana: {_mana}/{maxMana}");
        }
    }
}
