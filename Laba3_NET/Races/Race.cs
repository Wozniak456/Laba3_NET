using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{ /// <summary>
  /// Abstract product
  /// </summary>
    public abstract class Race
    {
        internal int Money { get; set; }
        internal int ForestSquare { get; set; }
        internal int FieldSquare { get; set; }
        internal int DwellingCount { get; set; }
        internal int FactoriesCount { get; set; }
        public abstract string Info();
        public abstract string TerritoryDescription();
        public abstract int GetMoney();
    }
}
