using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.StructuralPatterns.AdapterPattern
{
    class ReportGenerator2 : IReportGenerator
    {
        public void generateReport()
        {
            
                var oldImplementation = new OldReportGenerator();
                Console.WriteLine("Adding Header for Report 2");
                oldImplementation.reportGeneration();
                Console.WriteLine("Adding Footer for Report2");
           
        }
    }
}
