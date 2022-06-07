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
    public class Warrior : Race
    {
        public override int GetMoney()
        {
            Random rnd = new Random();
            Money = rnd.Next(50000, 60000);
            return Money;
        }
        public override string Info()
        {
            return "Воiн";
        }
        public override string TerritoryDescription()
        {
            Random rnd = new Random();
            ForestSquare = rnd.Next(100, 220);
            FieldSquare = rnd.Next(100, 220);
            DwellingCount = rnd.Next(50, 100);
            FactoriesCount = rnd.Next(2, 10);
            return $"ForestSquare: {ForestSquare}\nFieldSquare: {FieldSquare}\nDwellingCount: {DwellingCount}\nFactoriesCount: {FactoriesCount}";
        }
    }
}
