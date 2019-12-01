using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.CreationalPatterns.BuilderPattern
{
    class ShipBuilder : IBuilder
    {
        public void buildPart()
        {
            Console.WriteLine("Ship building completed.....");
        }
    }
}
