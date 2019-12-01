using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.StructuralPatterns.BridgePattern
{
    class BridgeOrchastrator
    {
        public void executor()
        {
            var reportObject1 = new ReportGenerator1();
            var reportObject2 = new ReportGenerator2();
            reportObject1.generateReport();
            reportObject2.generateReport();

        }
    }
}
