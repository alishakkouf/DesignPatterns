using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>

    class Report : Document
    {
        // Factory Method implementation

        public override void CreatePages()
        {
            Pages.Add(new SummaryPage());
        }
    }
}
