using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.BehavioralPatterns.InterpreterPattern
{
    class RunExample
    {
        public RunExample()
        {
            var evaluator = new Evaluator();
            Console.WriteLine("Enter RPN Expression");
            string text = Console.ReadLine();
            var tree = evaluator.Parse(text);
            Console.WriteLine("Result: {0}", tree.Interpret());
        }
        
    }
}
