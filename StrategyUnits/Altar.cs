namespace StrategyUnits
{
    internal class Altar
    {
        public delegate void AltarDelegate(int mana, string name,int energy, int MPHeal);
        public event AltarDelegate altarHealMP;
        private int _enegry = 1;
        public int _maxEnergy = 500;
        public int MPHeal = 10;
       
        public void RestoreMP(MagicUnit unit)
        {
            while (_maxEnergy >= 1 && unit.Mana < unit.MaxMana)
            {
                unit.Mana += MPHeal;
                _maxEnergy -= _enegry;
                altarHealMP.Invoke(unit.Mana,unit.Name,_enegry,MPHeal);
            }
        }
    }
}
