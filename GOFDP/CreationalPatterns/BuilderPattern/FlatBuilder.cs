using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.CreationalPatterns.BuilderPattern
{
    class FlatBuilder : IBuilder
    {
        public void buildPart()
        {
            Console.WriteLine("Building the Flat....");
        }
    }
}
