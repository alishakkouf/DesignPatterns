using System;
using System.Collections.Generic;

namespace Builder_Design_pattern
{
    /// <summary>
    /// The 'Product' class
    /// </summary>
    class Vehicle
    {
        private string _vehicleType;

        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        // Constructor
        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }

        // Indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine(" Frame : {0}", _parts[constants.Frame]);
            Console.WriteLine(" Engine : {0}", _parts[constants.Engine]);
            Console.WriteLine(" #Wheels: {0}", _parts[constants.Wheels]);
            Console.WriteLine(" #Doors : {0}", _parts[constants.Doors]);
        }
    }
}
