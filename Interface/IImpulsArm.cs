namespace Interface
{
    internal interface IImpulsArm: IArmItem
    {
        public int ImpulsDamage { get; }
        public void Shoot();
    }
}
