using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    class Singleton
    {
        private static Singleton _instance;
        private static Guid _id;
        private static object _lockObject = new object();
        public Guid id { get { return _id; } }
        private Singleton(Guid id)
        {
            _id = id;
        }
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                        _instance = new Singleton(Guid.NewGuid());
                }
            }
            return _instance;
        }
    }
}
