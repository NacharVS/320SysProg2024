using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IMagicUnitCapability
    {
        public int Change_manna { get; set; }
        public int MaxManna { get; set; }
        public void DecreaseManna (int manna);
        public void IncreaseManna(int manna);

        public delegate void MannaChangedDelegate(int manna, string? name, int change, int maxManna);

        public event MannaChangedDelegate MannaIncreasedEvent;
        public event MannaChangedDelegate MannaDecreasedEvent;
    }
}
