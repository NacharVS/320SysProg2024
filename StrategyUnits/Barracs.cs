namespace StrategyUnits
{
    internal class Barracs // class factory
    {
        public MilitaryUnit CreateRecruit()
        {
            return new MilitaryUnit(60, "Recruit",true, 3, 7, 2,0,0);
        }

        public MilitaryUnit CreateFootman()
        {
            return new MilitaryUnit(90, "Footman", true, 4, 12, 2, 0, 0);
        }

        public Berserker CreateBerserker()
        {
            return new Berserker(120, "Berserker", true, 4, 13,1, 0, 0);
        }
    }
}