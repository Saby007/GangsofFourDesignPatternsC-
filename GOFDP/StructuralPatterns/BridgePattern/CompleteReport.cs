using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.StructuralPatterns.BridgePattern
{
    abstract class CompleteReport
    {
        IReportGenerator reportFeatures;
        public abstract void generateReport();
    }
}
