using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Cleric : Unit, IMagicUnitCapability, IHill, IMagicAttack
    {
        private int _change_manna;
        
        public Cleric(string? name, bool deadperson, int change_health, int maxHealth, int manna, int maxManna, int magicDamage) : base (name, change_health, deadperson, maxHealth)
        {
            _change_manna = manna;
            MagicDamage = magicDamage;
            MaxManna = maxManna;
        }

        public int Manna { get; set; }
        public int MaxManna { get; set; }
        public int MagicDamage { get; set; }
        public int Change_manna
        {
            get { return _change_manna; }
            set
            {
                int beginEnergy = _change_manna;
                if (value < 0)
                {
                    _change_manna = 0;
                }
                else
                {
                    if (value > MaxManna)
                        _change_manna = MaxManna;
                    else
                        _change_manna = value;
                }
                if (value < beginEnergy)
                {
                    MannaDecreasedEvent.Invoke(_change_manna, this.Name, beginEnergy - value, MaxManna);
                }
                else if (value > beginEnergy)
                {
                    MannaIncreasedEvent.Invoke(_change_manna, this.Name, value - beginEnergy, MaxManna);
                }
            }
        }
        public void HillOthers(IHealth unit)
        {
            if (unit.DeadPerson)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unit died, you can't hill dead characters.");
                Console.ResetColor();
                return;
            }
            else
            {
                while (Change_manna >= 2)
                {
                    if (unit.MaxHealth <= unit.Change_Health)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.ResetColor();
                        return;
                    }
                    else if (Change_manna < 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Not enough manna.");

                    }
                    else
                    {
                        while (Change_manna >= 2)
                        {
                            unit.IncreaseHealth(1);
                            unit.DecreaseHealth(2);
                        }
                    }
                }
            }
        }
        public void HillMyself()
        {
            if (DeadPerson)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Name} died, You can't hill dead characters.");
                Console.ResetColor();
                return;
            }
            while (Manna > 0)
            {
                if (MaxHealth <= Change_Health)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{Name} hill");
                    Console.ResetColor();
                    return;
                }
                else if (Change_manna < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Not enough manna.");
                    Console.ResetColor();
                }
                else
                    while (Change_manna >= 1)
                    {
                        Change_Health += 2;
                        Change_manna -= 1;
                    }
                Console.WriteLine($"Character {Name} hill himself");
            }
        }


        public void IncreaseManna(int manna)
        {
            Change_Health += manna;
        }

        public void DecreaseManna(int manna)
        {
            Change_Health -= 2;
        }

        public void MagicAttack(IHealth unit)
        {
            //throw new NotImplementedException();
            DecreaseManna(1);
            unit.DecreaseHealth(4);
        }

        public override void ShowInfo()
        {
            Console.WriteLine($" Character: {Name}\n Health: {Change_Health}/{MaxHealth} \n Manna: {Change_manna}/{MaxManna} \n Magic Damage: {MagicDamage} \n Live? {!DeadPerson}");
        }

        public event IMagicUnitCapability.MannaChangedDelegate MannaDecreasedEvent;
        public event IMagicUnitCapability.MannaChangedDelegate MannaIncreasedEvent;

        //public event HillDelegate Hill_event;

        // манна, здоровье, пострадавший, нанесший
        //public void GetInfoCleric()
        //{
        //    Console.WriteLine($"Manna: {Manna}");
        //}
        //create event
    }
}
//Лечить себя: 1 мана = 2 здоровья
//Лечить ДРУГОГО : 2 маны = 1 здоровье