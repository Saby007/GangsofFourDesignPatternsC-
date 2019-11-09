using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.BehavioralPatterns.InterpreterPattern
{
    class Evaluator
    {
        public RPNExpression Parse(string text)
        {
            Stack<RPNExpression> stack = new Stack<RPNExpression>();
            string[] words = text.Split(' ');

            foreach(string word in words)
            {
                RPNExpression lhs = null, rhs = null;
                switch (word)
                {
                    case "+":
                        rhs = stack.Pop();
                        lhs = stack.Pop();
                        stack.Push(new Add(lhs, rhs));
                        break;
                    case "-":
                        rhs = stack.Pop();
                        lhs = stack.Pop();
                        stack.Push(new Subtract(lhs, rhs));
                        break;
                    case "*":
                        rhs = stack.Pop();
                        lhs = stack.Pop();
                        stack.Push(new Multiply(lhs, rhs));
                        break;
                    case "/":
                        rhs = stack.Pop();
                        lhs = stack.Pop();
                        stack.Push(new Multiply(lhs, rhs));
                        break;
                    default:
                        int number = int.Parse(word);
                        stack.Push(new Number(number));
                        break;
                }
            }
            return stack.Pop();
         }
    }
}
