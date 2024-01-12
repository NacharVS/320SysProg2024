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
            if (unit.Health == 0)
            {
                Console.WriteLine("You can't hill dead characters.");
            }
            else
            {
                unit.Health += 1;
                _manna -= 2;
            }
        }

        public void HillMyself(Cleric cleric)
        {
            cleric.Health += 2;
            _manna -= 1;
        }

        public void GetInfoCleric()
        {
            Console.WriteLine($"Manna: {_manna}");
        }
    }
}
//Лечить себя: 1 мана = 2 здоровья
//Лечить ДРУГОГО : 2 маны = 1 здоровье