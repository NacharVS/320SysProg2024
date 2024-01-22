using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : ZealotKnight
    {
        private bool _holyArmor;
        public bool HolyArmor
        {
            get
            {

                return _holyArmor;
            }
        }
        private string _nameOfUnit;

        public Paladin(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage, int manaPoints, int ArmorLevel, int WeaponLevel) : base(currentHealth, nameOfClass, defense, minDamage, maxDamage, manaPoints, ArmorLevel, WeaponLevel)
        {
            NameOfUnit = _nameOfUnit;
        }

        public string NameOfUnit
        {
            get { return _nameOfUnit; }
            set { _nameOfUnit = value; }
        }

        public override void AttackMagically(Unit attackedUnit)
        {
            Random rnd = new Random();
            int appliedDamage = rnd.Next(MinDamage * 2, MaxDamage * 2) - attackedUnit.Defense / 2;
            if (!attackedUnit.IsDead)
            {
                if (appliedDamage >= 0)
                {
                    if (this.ManaPoints > appliedDamage)
                    {
                        this.ManaPoints -= appliedDamage * 3;
                        Console.WriteLine($"Магическая атака прошла успешна!!. Вы нанесли {appliedDamage} MDP.\n");
                        attackedUnit.CurrentHealth -= appliedDamage;
                    }
                    else
                    {
                        Console.WriteLine("Атака была провалена. Не хватает маны для атаки.\n");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Атака была провалена.\n");
                }
            }
            else
            {
                Console.WriteLine("Юнит уже мертв. Остановитесь!!\n");
            }
        }

        public void HolyArmorOn()
        {
            if (CurrentHealth <= MaxHealth / 2 && _holyArmor == false)
            {

                Console.WriteLine($"Паладин {NameOfUnit} был благословлен святой броней\n");
                Defense *= 2;
                _holyArmor = true;
            }
        }
        public void HolyArmorOff()
        {
            if (CurrentHealth > MaxHealth / 2 && _holyArmor == true)
            {
                Defense /= 2;
                _holyArmor = false;
            }
        }

        public override void ShowInfo()
        {

            Console.WriteLine(
                $"{NameOfUnit} - юнит {NameOfClass} класса\n" +
               $"Здоровье: {CurrentHealth}/{MaxHealth}\n" +
               $"Броня: {Defense}\n" +
               $"Урон (Мин - Макс): {MinDamage} - {MaxDamage}\n" +
               $"Мана: {ManaPoints}\n");

        }
    }
}

