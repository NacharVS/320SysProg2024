namespace Interface
{
    internal interface IBomb : IArmItem
    {
        public void BombAttack();
        public int BombDamage {  get; }
    }
}
