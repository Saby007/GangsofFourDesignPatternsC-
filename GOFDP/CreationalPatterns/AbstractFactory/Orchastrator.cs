using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.CreationalPatterns.AbstractFactory
{
    class Orchastrator
    {
        public Orchastrator()
        {
            IRules ruleProcessor1 = new ProcessRule1("grading");
            IExecutor execute = new GradingExecutor();
            execute.executeRules(ruleProcessor1);
            IRules ruleProcessor2 = new ProcessRule2("reports");
            execute = new ReportExecutor();
            execute.executeRules(ruleProcessor2);
        }
        
    }
}
