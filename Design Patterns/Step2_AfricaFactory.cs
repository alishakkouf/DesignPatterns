using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    class Step2_AfricaFactory : ContinentFactory
    {
        public override Step4_Herbivore CreateHerbivore()
        {
            return new Step6_Wildebeest();
        }
        public override Step5_Carnivore CreateCarnivore()
        {
            return new Step6_Lion();
        }
    }
}
