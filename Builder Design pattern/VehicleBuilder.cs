namespace Builder_Design_pattern
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    abstract class VehicleBuilder
    {
        protected Vehicle vehicle { get; set; }

        // Gets vehicle instance
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }
        // Abstract build methods
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
