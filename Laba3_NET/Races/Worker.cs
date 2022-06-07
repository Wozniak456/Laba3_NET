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
    public class Worker : Race
    {
        public override string Info()
        {
            return "Працiвник";
        }
        public override string TerritoryDescription()
        {
            Random rnd = new Random();
            ForestSquare = rnd.Next(200, 300);
            FieldSquare = rnd.Next(200, 300);
            DwellingCount = rnd.Next(70, 130);
            FactoriesCount = rnd.Next(10, 30);
            return $"ForestSquare: {ForestSquare}\nFieldSquare: {FieldSquare}\nDwellingCount: {DwellingCount}\nFactoriesCount: {FactoriesCount}";
        }
        public override int GetMoney()
        {
            Random rnd = new Random();
            Money = rnd.Next(20000, 50000);
            return Money;
        }
    }
}
