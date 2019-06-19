
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton
            /*
            Singleton singleton1 = Singleton.GetInstance();
            Console.WriteLine(singleton1.id.ToString());
            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine(singleton2.id);
            */

            //Builder
            /*
            Director director = new Director();
            Builder b1 = new ConcreateBuilder1();
            Builder b2 = new ConcreateBuilder2();
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();
            */

            //Factory
            /*Creator creator = new Creator();
            creator.ScreenFactory(ScreenMode.Windows).Draw();
            creator.ScreenFactory(ScreenMode.Web).Draw();
            creator.ScreenFactory(ScreenMode.Mobile).Draw();

            // 2.yol
            Creator2[] creators =
            {
                new WinScreenCreator(),
                new WebScreenCreator(),
                new MobileScreenCreator()
            };
            foreach (var item in creators)
            {
                item.ScreenFactory().Draw();
            }
            */

            //Prototype
            /*
            List<Prototype> Entities = new List<Prototype>();
            Product lcdTV = new Product(1000, "ABC LCD TV 106", 1000);
            Entities.Add(lcdTV);

            Person bill = new Person("Bill");
            Entities.Add(bill);

            Entities.Add(lcdTV.Clone() as Product);
            Entities.Add(bill.Clone() as Person);
            */

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
