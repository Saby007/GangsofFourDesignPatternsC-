using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.CreationalPatterns.AbstractFactory
{
    interface IExecutor
    {
        void executeRules(IRules ruleProcessor);
    }
}
