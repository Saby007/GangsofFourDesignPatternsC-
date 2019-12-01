using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.StructuralPatterns.BridgePattern
{
    class ReportGenerator1 : CompleteReport
    {
        private IReportGenerator _rg;
        public ReportGenerator1()
        {
            _rg = new ReportGenerator();
        }
        public override void generateReport()
        {
            _rg.addHeader();
            Console.WriteLine("Body created for report 1.....");
            _rg.addFooter();
        }
    }
}
