namespace Interface
{
    internal interface IArmItem
    {
        public delegate void ShowInfoDelegate(string name, int damage, int otherDamaage, int classArm);

        public string Name { get; }
        public int Damage { get; }
        public int ClassArm { get; }
    }
}
