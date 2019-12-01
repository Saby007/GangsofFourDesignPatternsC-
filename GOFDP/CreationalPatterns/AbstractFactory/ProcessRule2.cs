using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.CreationalPatterns.AbstractFactory
{
    class ProcessRule2 : IRules
    {
        private string _ruleKey;
        private List<string> _ruleLists;
        public ProcessRule2(string ruleKey)
        {
            _ruleKey = ruleKey;
        }
        public void create()
        {
            _ruleLists = getRules(_ruleKey);
            Console.WriteLine("Processing Rule2..........");
            foreach (string rule in _ruleLists)
            {
                Console.WriteLine("Processed rule: " + rule);
            }
            Console.WriteLine("Processed..........");
        }

        private List<string> getRules(string _ruleKey)
        {
            return new List<string> { "Rule2", "Rule3" };
        }
    }
}
