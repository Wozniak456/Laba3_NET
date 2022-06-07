using ConsoleApp6.CavilizationType;
using ConsoleApp6.Races;

namespace ConsoleApp6.Civilizations
{
    /// <summary>
    /// Abstract factory
    /// </summary>
    public abstract class CivilizationFactory
    {
        public abstract Warrior CreateWarrior();
        public abstract Worker CreateWorker();
        public abstract Aristocrat CreateAristocrat();
        //public abstract NewRace CreateNewRace();
    }
    /// <summary>
    /// Concrete factory
    /// </summary>
    public class MaiiaFactory : CivilizationFactory
    {
        public override Warrior CreateWarrior()
        {
            return new MaiiaWarrior();
        }

        public override Worker CreateWorker()
        {
            return new MaiiaWorker();
        }

        public override Aristocrat CreateAristocrat()
        {
            return new MaiiaAristocrat();
        }

        /*public override NewRace CreateNewRace()
        {
            return new MaiiaNewRace();
        }
         */
    }
    /// <summary>
    /// Concrete factory
    /// </summary>
    public class NyiiaFactory : CivilizationFactory
    {
        public override Warrior CreateWarrior()
        {
            return new NyiiaWarrior();
        }
        public override Worker CreateWorker()
        {
            return new NyiiaWorker();
        }

        public override Aristocrat CreateAristocrat()
        {
            return new NyiiaAristocrat();
        }

        /*public override NewRace CreateNewRace()
        {
            return new NyiiaNewRace();
        }
         */
    }
}
