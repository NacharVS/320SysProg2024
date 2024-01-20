namespace StrategyUnits
{
    internal class MagicUnit: MilitaryUnit
    {
        public event HealthChangedDelegate ShowInfoCliric;
        private int _mana;
        public int MaxMana { get; set; }
        public MagicUnit(int health, string? name, bool active, int damage, int maxDamage, int mana,int armors, int lvlappArmor, int lvlappAttack) : base(health, name, active, damage, maxDamage,armors, lvlappArmor,lvlappAttack)
        {
            _mana = mana;
            MaxMana = _mana;
        }
        public virtual int Mana
        {
            get => _mana;
            set
            {
                if (value < 0)
                    _mana = 0;
                else
                    if (value > MaxMana)
                    _mana = MaxMana;
                else
                    _mana = value;
            }
        }
       
        public override void ShowInfo()
        {
            if (!_active)
                ShowInfoCliric.Invoke(Health, Name, 1, _mana);
            else
                ShowInfoCliric.Invoke(Health, Name, 0, _mana);
        }
    }
}
