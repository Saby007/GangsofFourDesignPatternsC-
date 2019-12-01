using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP.CreationalPatterns.Singleton
{
    class SingletonSample
    {
        private static SingletonSample _instance = null;
        // this field holds the lock handle for thread locking
        private static object _handle = new object();

        private int count;

        protected SingletonSample()
        {
            count = 1;
        }

        public void addCount()
        {
            count += 1;
        }

        public static SingletonSample Instacnce
        {
            get
            {
                lock (_handle)
                {
                    if(_instance == null)
                    {
                        _instance = new SingletonSample();
                    }
                }
                return _instance;
            }
        }

        public int Count
        {
            get { return count; }
        }

    }
}
