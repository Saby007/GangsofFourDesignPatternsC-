using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.StructuralPatterns.BridgePattern
{
    class ReportGenerator : IReportGenerator
    {
        public void addFooter()
        {
            Console.WriteLine("Footer Generated.......");
        }

        public void addHeader()
        {
            Console.WriteLine("Header Generated........");
        }
    }
}
