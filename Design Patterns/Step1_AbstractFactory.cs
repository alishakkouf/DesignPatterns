namespace Design_Patterns
{
    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    abstract class ContinentFactory
    {
        public abstract Step4_Herbivore CreateHerbivore();
        public abstract Step5_Carnivore CreateCarnivore();
    }
}
