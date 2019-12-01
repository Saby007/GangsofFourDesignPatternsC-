using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.StructuralPatterns.ProxyPattern
{
    class RealOperation : IOperation
    {
        public void request()
        {
            Console.WriteLine("Real Operation performs activity");
        }
    }
}
