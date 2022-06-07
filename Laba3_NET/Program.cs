using ConsoleApp6;
using ConsoleApp6.Civilizations;
using System;
namespace task05
{
    class Program
    {
        static void Main(string[] args)
        {
            MaiiaFactory MaiiaFactory = new MaiiaFactory();
            NyiiaFactory NyiiaFactory = new NyiiaFactory();

            Civilization Maiia = new Civilization(MaiiaFactory);
            Race[] MaiiaRaces = Maiia.CreateCivilization();

            Console.WriteLine("Civilization Maiia");
            foreach (Race race in MaiiaRaces)
            {
                Console.WriteLine($"{race.Info()} has \n{race.GetMoney()} $");
                PrintInColor(race.TerritoryDescription());
            }

            Console.WriteLine();

            Civilization Nyiia = new Civilization(NyiiaFactory);
            Race[] NyiiaRaces = Nyiia.CreateCivilization();

            Console.WriteLine("Civilization Nyiia");
            foreach (Race race in NyiiaRaces)
            {
                Console.WriteLine($"{race.Info()} has \n{race.GetMoney()} $");
                PrintInColor(race.TerritoryDescription());
            }
        }
        static void PrintInColor(string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }
}