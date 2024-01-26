namespace StrategyUnits
{
    internal class Barracs // class factory
    {
        public Footman CreateRecruit()
        {
            return new Footman("Recruit", 60, 5, 7, 10);
        }

        public Footman CreateFootman()
        {
            return new Footman("Foorman", 90, 7, 10, 15);
        }

        public Berserc CreateBerserker()
        {
            return new Berserc("Berserc", 120, 10, 15, 20);
        }
    }
}
