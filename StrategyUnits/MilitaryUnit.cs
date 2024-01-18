using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        public delegate void InflictDamageDelegate(int damage, int health, string nameDealtDamage, string nameReceivedDamage); //Делегат НанесенияУрона -- ПолучилУрон, НанесУрон
        //Урон
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        //Метод нанесения урона
        public void InflictDamage(Unit unit)
        {
            if (IsDead == true)
                Console.WriteLine("Unit мертв");
            else
            {
                unit.Health -= _damage;
                InflictDamageEvent.Invoke(_damage, unit.Health, Name, unit.Name); //При нанесении урона вызывается событие
            }
        }

        public MilitaryUnit(int health, string? name, int damage) : base(health, name)
        {
            _damage = damage;
        }

        public event InflictDamageDelegate InflictDamageEvent; //Ивет НанесенияУрона
    }
}
