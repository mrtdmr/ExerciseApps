using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Mudur m = new Mudur(3500);
            Console.WriteLine(m.ZamYap(2500));
            Baskan b = new Baskan(5600);
            Console.WriteLine(b.ZamYap(1000));
        }
    }
}
