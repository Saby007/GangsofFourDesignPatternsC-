using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.StructuralPatterns.ProxyPattern
{
    class ProxyOrchastrator
    {
        public ProxyOrchastrator()
        {
            new ProxyOperaration(new RealOperation()).request();
        }
    }
}
