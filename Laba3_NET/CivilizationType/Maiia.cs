using ConsoleApp6.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.CavilizationType
{
    public class MaiiaWarrior : Warrior
    {
        public override string Info()
        {
            return "Warrior of Maiia civilization";
        }
    }
    public class MaiiaWorker : Worker
    {
        public override string Info()
        {
            return "Worker of Maiia civilization";
        }
    }
    public class MaiiaAristocrat : Aristocrat
    {
        public override string Info()
        {
            return "Aristocrat of Maiia civilization";
        }
    }

    /*
     *  public class MaiiaNewRace : NewRace
    {
        public override string Info()
        {
            return "NewRace of Maiia civilization";
        }
    }
     */
}
