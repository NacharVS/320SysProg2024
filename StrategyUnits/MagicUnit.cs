namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        public delegate void ManaChangedDelegate(string name, int maxMana);
        ManaChangedDelegate ManaLossEvent;
        ManaChangedDelegate ManaGetEvent;
        private int _currentMana;
        public int MaximumMana { get; private set; }
        public int Mana
        {
            get { return _currentMana; }
            set
            {
                if ( value < 0)
                {
                    _currentMana = 0;
                }
                else
                {
                    if (_currentMana > MaximumMana)
                    {
                        _currentMana = MaximumMana;
                    }
                    else
                    {
                        _currentMana = value;
                    }
                }
                if ( value < _currentMana)
                {
                    ManaLossEvent.Invoke(this.Name, Mana);
                }
                else if (value < _currentMana)
                {
                    ManaGetEvent.Invoke(this.Name, Mana);
                }
            }
        }
        public MagicUnit(string? name, int maxHP, int maxProtect, int damage, int maxMana) : base(name, maxHP, maxProtect, damage)
        {
            MaximumMana = maxMana;
            _currentMana = MaximumMana;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($" Unit: {this.Name} Health: {this.CurrentHP}/{this.MaximumHP} Mana: {this.Mana}/{this.MaximumMana} Damage: {this.Damage} Protection: {Protection}/{MaximumProtect} LvlWeapon: {WeaponLvl} LvlArmor: {ArmorLvl}");
        }
    }
}
