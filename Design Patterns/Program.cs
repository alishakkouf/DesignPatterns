using System;

namespace Design_Patterns
{
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            // Create and run the African animal world
            ContinentFactory africa = new Step2_AfricaFactory();

            Step7_AnimalWorld world = new Step7_AnimalWorld(africa);

            world.RunFoodChain();

            // Create and run the American animal world
            ContinentFactory america = new Step3_AmericaFactory();

            world = new Step7_AnimalWorld(america);

            world.RunFoodChain();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
