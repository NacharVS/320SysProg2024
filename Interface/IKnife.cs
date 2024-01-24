namespace Interface
{
    internal interface IKnife : IArmItem
    {
        public int Bleeding { get; }
        public void Hit();
    }
}
