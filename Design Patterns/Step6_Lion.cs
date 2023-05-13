using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    class Step6_Lion : Step5_Carnivore
    {
        public override void Eat(Step4_Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
