using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.BehavioralPatterns.InterpreterPattern
{
    /// <summary>
    /// Number Terminal Expression Class 
    /// </summary>
    class Number : RPNExpression
    {
        /// <summary>
        /// The value of the number
        /// </summary>
        protected int _value = 0;

        /// <summary>
        /// Initializes the class with the default value
        /// </summary>
        /// <param name="value">Default value</param>
        public Number(int value)
        {
            _value = value;
        }

        /// <summary>
        /// Interpret the expression
        /// </summary>
        /// <returns>value of the expression</returns>
        public override int Interpret()
        {
            return _value;
        }
    }
}
