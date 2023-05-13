using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    /// <summary>
    /// The 'Client' class 
    /// </summary>
    class Step7_AnimalWorld
    {
        private Step4_Herbivore _herbivore;
        private Step5_Carnivore _carnivore;
        // Constructor
        public Step7_AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }
        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
