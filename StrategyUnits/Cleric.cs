using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Cleric : Unit
    {
        private int _manna;
        public int MaxManna { get; private set; }


        public int Manna
        {
            get { return _manna; }
            set 
            {
                if (value < 0)
                    _manna = 0;
                
                else 
                    if (value > MaxManna)
                    _manna = MaxManna;
                else 
                    _manna = value;
            }
        }

        public Cleric() : base(70, "Cleric")
        {
            _manna = 50;
            MaxManna = _manna;
        }

        public void HillOthers(Unit unit)
        {
            if (DeadPerson == true)
            {
                Console.WriteLine($"{unit.Name} died, You can't hill dead characters.");
                return;
            }

            while (_manna >= 2)
            {
                 if (unit.MaxHealth <= unit.Health)
                 {
                     Console.WriteLine($"{unit.Name} hill.");
                     return;
                 }                 
                 unit.Health += 1;
                 _manna -= 2; 
            }
        }

        public void HillMyself(Unit unit) 
        {
            if (DeadPerson == true)
            {
                Console.WriteLine($"{unit.Name} died, You can't hill dead characters.");
                return;
            }
            while (_manna > 0)
            {
                if (unit.MaxHealth <= unit.Health)
                {
                    Console.WriteLine($"{unit.Name} hill");
                    return;
                }
                unit.Health += 2;
                _manna -= 1;
            }
        }

        public void GetInfoCleric()
        {
            Console.WriteLine($"Manna: {_manna}");
        }
    }
}
//Лечить себя: 1 мана = 2 здоровья
//Лечить ДРУГОГО : 2 маны = 1 здоровье