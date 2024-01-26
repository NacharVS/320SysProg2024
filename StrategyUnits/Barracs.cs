namespace StrategyUnits
{
    internal class Barracs // class factory
    {
        public Footman CreateRecruit()
        {
            return new Footman(60, "Recruit", 7);
        }

        public Footman CreateFootman()
        {
            return new Footman(90, "Footman", 10);
        }

        public Footman CreateBerserker()
        {
            return new Footman(120, "Berserker", 15);
        }
    }
}
