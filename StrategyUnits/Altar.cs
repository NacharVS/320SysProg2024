using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {

		private string _altarName;

		public string AltarName
		{
			get { return _altarName; }
			set { _altarName = value; }
		}

		private int _capability;

		public int Capability
		{
			get { return _capability; }
			set { _capability = value; }
		}

		public Altar(string altarName)
		{
			AltarName = altarName;
			Capability = 5000;
		}

		public void RestoreMana(MagicUnit restorableUnit)
		{
			if (restorableUnit.MaxManaPoints != restorableUnit.ManaPoints)
			{
				int manaDifference = restorableUnit.MaxManaPoints - restorableUnit.ManaPoints;
				restorableUnit.ManaPoints += manaDifference;
				this.Capability -= manaDifference * 5;
				Console.WriteLine($">> Altar has restored {manaDifference} MP, losing {manaDifference*5} EP of its' capability.\n");
            }
		}

		public void ShowInfo()
		{
            Console.WriteLine($"====== BUILDING ========\n" +
                $"{AltarName} - an altar\n" +
				$"Its' capability is {Capability} EP\n" +
               $"====== ========= ========\n");
        }
	}
}
