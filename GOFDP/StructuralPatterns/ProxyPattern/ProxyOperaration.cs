using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.StructuralPatterns.ProxyPattern
{
    class ProxyOperaration : IOperation
    {
        private IOperation _operation;
        public ProxyOperaration(IOperation operation)
        {
            _operation = operation;
        }
        public void request()
        {
            Console.WriteLine("Doing something, like Lazy Loading, security checks or remote access");
            _operation.request();
        }
    }
}
