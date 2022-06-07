using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    /// <summary>
    /// Product
    /// </summary>
    public class Aristocrat : Race
    {
        public override string Info()
        {
            return "Аристократ";
        }
        public override string TerritoryDescription()
        {
            Random rnd = new Random();
            ForestSquare = rnd.Next(200, 350);
            FieldSquare = rnd.Next(200, 350);
            DwellingCount = rnd.Next(100, 200);
            FactoriesCount = rnd.Next(100, 200);
            return $"ForestSquare: {ForestSquare}\nFieldSquare: {FieldSquare}\nDwellingCount: {DwellingCount}\nFactoriesCount: {FactoriesCount}";
        }
        public override int GetMoney()
        {
            Random rnd = new Random();
            Money = rnd.Next(100000, 200000);
            return Money;
        }
    }
}
