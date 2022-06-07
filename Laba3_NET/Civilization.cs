using ConsoleApp6.Civilizations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    /// <summary>
    /// Client
    /// </summary>
    public class Civilization
    {
        private CivilizationFactory _civilizationFactory;
        private Race[] _civilazations;
        public Civilization(CivilizationFactory currFactory)
        {
            _civilizationFactory = currFactory;
        }
        public Race[] CreateCivilization()
        {
            _civilazations = new Race[3];
            _civilazations[0] = _civilizationFactory.CreateWarrior();
            _civilazations[1] = _civilizationFactory.CreateWorker();
            _civilazations[2] = _civilizationFactory.CreateAristocrat();
            /*
             * _civilazations = new Race[4];
             * _civilazations[0] = _civilizationFactory.CreateWarrior();
             * _civilazations[1] = _civilizationFactory.CreateWorker();
             * _civilazations[2] = _civilizationFactory.CreateAristocrat();
             * _civilazations[3] = _civilizationFactory.CreateAristocrat();
             */
            return _civilazations;
        }

    }
}
