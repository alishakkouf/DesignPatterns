using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    class Step3_AmericaFactory : ContinentFactory
    {
        public override Step4_Herbivore CreateHerbivore()
        {
            return new Step6_Bison();
        }
        public override Step5_Carnivore CreateCarnivore()
        {
            return new Step6_Wolf();
        }
    }
}
