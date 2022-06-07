using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Races
{/// <summary>
/// Додавання нової раси
/// </summary>
    public class NewRace : Race
    {
        public override string Info()
        {
            return "Нова раса";
        }
        public override string TerritoryDescription()
        {
            Random rnd = new Random();
            ForestSquare = rnd.Next(1, 1000);
            FieldSquare = rnd.Next(1, 1000);
            DwellingCount = rnd.Next(1, 1000);
            FactoriesCount = rnd.Next(1, 1000);
            return $"ForestSquare: {ForestSquare}\nFieldSquare: {FieldSquare}\nDwellingCount: {DwellingCount}\nFactoriesCount: {FactoriesCount}";
        }
        public override int GetMoney()
        {
            Random rnd = new Random();
            Money = rnd.Next(1000000, 2000000);
            return Money;
        }
    }
}
