using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.CreationalPatterns.BuilderPattern
{
    class Director
    {
        public Director(IBuilder builder)
        {
            builder.buildPart();
        }
    }
}
