using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.CavilizationType
{
    public class NyiiaWarrior : Warrior
    {
        public override string Info()
        {
            return "Warrior of Nyiia civilization";
        }
    }
    public class NyiiaWorker : Worker
    {
        public override string Info()
        {
            return "Worker of Nyiia civilization";
        }
    }
    public class NyiiaAristocrat : Aristocrat
    {
        public override string Info()
        {
            return "Aristocrat of Nyiia civilization";
        }
    }
    /* public class NyiiaNewRace : NewRace
    {
        public override string Info()
        {
            return "NewRace of Nyiia civilization";
        }
    }
     */
}
