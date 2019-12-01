using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.StructuralPatterns.BridgePattern
{
    class ReportGenerator2 : CompleteReport
    {
        private IReportGenerator _rg;
        public ReportGenerator2()
        {
            _rg = new ReportGenerator();
        }
        public override void generateReport()
        {
            _rg.addHeader();
            Console.WriteLine("Body created for report 2............");
            _rg.addFooter();
        }
    }
}
