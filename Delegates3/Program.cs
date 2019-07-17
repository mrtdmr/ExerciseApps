using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates3
{
    class Program
    {
        //public delegate bool Filters(string item);
        //public delegate void Printer(string message);
        //public delegate bool CheckLengthOfString(string message);
        //public delegate int GetLengths(string message);
        static void Main(string[] args)
        {
            string[] names = { "Alice", "John", "Bobby", "Kyle", "Scott", "Tod", "Sharon", "Armin", "George" };
            //Func<string, bool> lessThanFive = LessThanFive;
            //List<string> namesLessThanFive = NamesFilter(names, LessThanFive);
            //List<string> namesLessThanFive = NamesFilter(names, x=>x.Length<5);
            //Console.WriteLine(string.Join(", ",namesLessThanFive));
            //Action<string> p = Print;
            //p += PrintTwice;
            //p("Message");
            //Console.WriteLine(string.Join(", ",NamesFilter(names, ExactlyFive)));
            //Console.WriteLine(string.Join(", ", NamesFilter(names, item => item.Length > 5)));
            //Printer p = Print;
            //p += PrintTwice;
            //p("Message");
            //foreach (var del in p.GetInvocationList())
            //{
            //    Console.WriteLine(del.Method);
            //}
            //Delegate[] delegates = p.GetInvocationList();
            //CheckLengthOfString d = LessThanFive;
            //d += MoreThanFive;
            //d += ExactlyFive;

            //GetLengths g = x => x.Length;
            //g += x => x.Length+1;
            //g += x => x.Length+2;
            //List<bool> results = new List<bool>();
            //foreach (var del in d.GetInvocationList())
            //{
            //    results.Add((bool)del.DynamicInvoke("Message"));
            //}
            //Console.WriteLine(string.Join(", ",results));

            //List<bool> results = GottaCatchEmAll<bool>(d, "Message");
            //List<int> lengths = GottaCatchEmAll<int>(g, "Message");
            //Console.WriteLine(string.Join(", ", results));
            //Console.WriteLine(string.Join(", ", lengths));
            //Func<int, int, bool> checkIntegers = (i, j) => i < 8 + j;
            //Action printsSth = () => Console.WriteLine("Print");
            //printsSth();
            //Action<int, int> sumOfTwoNumbers = (i, j) =>
            //{
            //    Console.WriteLine("The i number is " + i);
            //    Console.WriteLine("The j number is " + j);
            //    Console.WriteLine("Sum of i and j is " +(i+j));
            //};
            //sumOfTwoNumbers(5,3);
            //Func<string[], Func<string, bool>, List<string>> extractStrings = (array, filter) =>
            //    {
            //        List<string> results = new List<string>();
            //        foreach (var item in array)
            //        {
            //            if (filter(item))
            //            {
            //                results.Add(item);
            //            }
            //        }
            //        return results;
            //    };
            //Func<string, bool> lessThanFive = x => x.Length < 5;
            //Func<string, bool> moreThanFive = x => x.Length > 5;
            //List<string> namesLessThanFiveChars = extractStrings(names, lessThanFive);
            //List<string> namesMoreThanFiveChars = extractStrings(names, moreThanFive);
            //Console.WriteLine(string.Join(", ", namesLessThanFiveChars));
            //Console.WriteLine(string.Join(", ", namesMoreThanFiveChars));
        }
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
        public static void PrintTwice(string message)
        {
            Console.WriteLine(message + "1");
            Console.WriteLine(message + "2");
        }

        public static List<T> GottaCatchEmAll<T>(Delegate del, object parameter = null)
        {
            List<T> result = del.GetInvocationList()
                .Select(d => (T)d.DynamicInvoke(parameter))
                .ToList();
            return result;
        }
        public static bool LessThanFive(string name)
        {
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
        public static List<string> NamesFilter(string[] items, Func<string, bool> filter)
        {
            List<string> result = new List<string>();
            foreach (var item in items)
            {
                if (filter(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
