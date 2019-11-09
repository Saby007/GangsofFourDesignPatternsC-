using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.BehavioralPatterns.InterpreterPattern
{
    class Subtract : RPNExpression
    {
        protected RPNExpression _lhs = null;
        protected RPNExpression _rhs = null;

        public Subtract(RPNExpression lhs, RPNExpression rhs)
        {
            _lhs = lhs;
            _rhs = rhs;
        }

        public override int Interpret()
        {
            return _lhs.Interpret() - _rhs.Interpret();
        }
    }
}
