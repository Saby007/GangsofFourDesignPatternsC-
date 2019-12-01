using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.CreationalPatterns.BuilderPattern
{
    class BuilderOrchastrator
    {
        public BuilderOrchastrator()
        {
            new Director(new FlatBuilder());
            new Director(new ShipBuilder());
        }
    }
}
