using System.Xml.Linq;

namespace StrategyUnits
{
    
    internal class Healer : Unit
    {
        private int _mana;
        private int _maxMana;
        
        public Healer() : base(50, "Healer")
        {
            _maxMana = 60;
            _mana = _maxMana;
        }

        public int Mana
        {
            get { return _mana; }            
            set
            {
                if (value < 0)
                    _mana = 0;
                else if (value > _maxMana)
                    _mana = _maxMana;
                else
                    _mana = value;
            }
        }

        public void HealSomebody(Unit unit)
        {
            while(_mana > 0 || MaxHealth - Health > 0)
            {
                Health += 1;
                _mana -= 2;
            }
        }

        public void HealSelf (Unit unit)
        {
            while (_mana > 0 || MaxHealth - Health > 0)
            {
                Health += 2;
                _mana -= 1;
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health} Mana: {_mana}" );
        }
    }
}
