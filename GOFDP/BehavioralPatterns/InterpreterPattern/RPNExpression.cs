using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.BehavioralPatterns.InterpreterPattern
{
    /// <summary>
    /// RPNExpression abstract class
    /// </summary>
    abstract class RPNExpression
    {
        /// <summary>
        /// Abstract method to Interpret the expression
        /// </summary>
        /// <returns>value of the expression</returns>
        public abstract int Interpret();
    }
}
