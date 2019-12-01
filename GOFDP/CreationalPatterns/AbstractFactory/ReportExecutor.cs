using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.CreationalPatterns.AbstractFactory
{
    class ReportExecutor : IExecutor
    {
        public void executeRules(IRules ruleProcessor)
        {
            ruleProcessor.create();
        }
    }
}
