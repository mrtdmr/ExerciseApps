using System;
using System.Collections.Generic;

namespace Delegates3
{
    class Program
    {
        public delegate bool Filters(string item);
        public delegate void Printer(string message);
        static void Main(string[] args)
        {
            //string[] names = { "Alice", "John", "Bobby", "Kyle", "Scott", "Tod", "Sharon", "Armin", "George" };
            //Console.WriteLine(string.Join(", ",NamesFilter(names, ExactlyFive)));
            //Console.WriteLine(string.Join(", ", NamesFilter(names, item => item.Length > 5)));
            Printer p = Print;
            p += PrintTwice;
            p("Message");
            foreach (var del in p.GetInvocationList())
            {
                Console.WriteLine(del.Method);
            }
            Delegate[] delegates = p.GetInvocationList();
        }
        public static void Print(string message) {
            Console.WriteLine(message);
        }
        public static void PrintTwice(string message)
        {
            Console.WriteLine(message+"1");
            Console.WriteLine(message+"2");
        }
        /*
        public static bool LessThanFive(string name) {
            return name.Length < 5;
        }
        public static bool MoreThanFive(string name)
        {
            return name.Length > 5;
        }
        public static bool ExactlyFive(string name)
        {
            return name.Length == 5;
        }
        */
        //public static List<string> NamesFilter(string[] items, Filters filter)
        //{
        //    List<string> result = new List<string>();
        //    foreach (var item in items)
        //    {
        //        if (filter(item))
        //        {
        //            result.Add(item);
        //        }
        //    }
        //    return result;
        //}
    }
}
