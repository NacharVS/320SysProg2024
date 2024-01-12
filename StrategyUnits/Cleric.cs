namespace StrategyUnits
{
    internal class Cleric : Unit
    {
        private int _maxEnergy;
        private int _currentEnergy;

        public int CurrentEnergy
        {
            get { return _currentEnergy; }
            set
            {
                if (value > MaxEnergy)
                    _currentEnergy = MaxEnergy;
                else
                    _currentEnergy = value;
            }
        }
        public int MaxEnergy
        {
            get { return _maxEnergy; }
            set { _maxEnergy = value; }
        }
        public Cleric() : base(15, "Cleric")
        {
            _maxEnergy = 5;
            _currentEnergy = _maxEnergy;
        }

        public void HealSelf(Unit unit)
        {
            var healthBeforeHealth = unit.CurrentHealth;
            if (unit.IsDied)
            {
                Console.WriteLine($"{unit.Name} умер, восстановить здоровье нельзя");
                return;
            }
            while (_currentEnergy > 0)
            {
                if (unit.MaxHealth <= unit.CurrentHealth)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{unit.Name} исцелился с {healthBeforeHealth} до {unit.CurrentHealth}");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                unit.CurrentHealth += 2;
                _currentEnergy -= 1;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{unit.Name} исцелился с {healthBeforeHealth} до {unit.CurrentHealth}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void HealSomebody(Unit unit)
        {
            var healthBeforeHealth = unit.CurrentHealth;
            if (unit.IsDied)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{unit.Name} умер, восстановить здоровье нельзя");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            while (_currentEnergy > 0)
            {
                if (unit.MaxHealth <= unit.CurrentHealth)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{unit.Name} исцелился с {healthBeforeHealth} до {unit.CurrentHealth}");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                if (_currentEnergy < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Недостаточно энергии для проведения лечения {unit.Name} не хватает 1 очка");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                unit.CurrentHealth += 1;
                _currentEnergy -= 2;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{unit.Name} исцелился с {healthBeforeHealth} до {unit.CurrentHealth}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void RecoveryEnergy(Cleric cleric)
        {
            cleric.CurrentEnergy = MaxEnergy;
            Console.WriteLine($"{cleric.Name} энергия восстановлена до {cleric.CurrentEnergy}");
        }
    }
}
