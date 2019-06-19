using DesignPatterns.Creational.Singleton;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton
            Singleton singleton1 = Singleton.GetInstance();
            Console.WriteLine(singleton1.id.ToString());
            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine(singleton2.id);

            //Abstract Factory
            /*
            Factory factory = new Factory(new InterBaseFactory());
            factory.Start();
            Factory factory2 = new Factory(new DB2Factory());
            factory2.Start();
            */
        }
    }
}
