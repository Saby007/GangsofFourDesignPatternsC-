using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.StructuralPatterns.AdapterPattern
{
    class AdapterOrchastrator
    {
        public AdapterOrchastrator()
        {
            IReportGenerator reportAdapter = new ReportGenerator1();
            reportAdapter.generateReport();
            reportAdapter = new ReportGenerator2();
            reportAdapter.generateReport();
        }
               
    }
}
