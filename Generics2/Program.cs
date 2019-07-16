using System;
using System.Collections.Generic;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(AreEqual(1, 1));
            //int[] intArray = { 1, 59, 4, 2, 6, 7, 10, 25 };
            //int[] sortedIntArray = Sort(intArray);
            //string[] strArray = { "fdg", "fde", "bcd", "asc", "asv" };
            //string[] sortedStrArray = Sort(strArray);
            //Console.WriteLine(string.Join(", ", sortedIntArray));
            //Console.WriteLine(string.Join(", ", sortedStrArray));
            //Person p1 = new Person { Age = 20 };
            //Person p2 = new Person { Age = 20 };
            //Console.WriteLine(AreEqual(p1, p2));

            MyList<int> firstIntList = new MyList<int>();
            MyList<int> secondIntList = new MyList<int>();
            
            //Console.WriteLine(firstIntList.Capacity);
            //Console.WriteLine(firstIntList.Count);
            firstIntList.Add(10);
            firstIntList.Add(15);
            firstIntList.Add(52);
            secondIntList.Add(1);
            secondIntList.Add(3);
            secondIntList.Add(4);
            MyList<int> resultIntList = firstIntList + secondIntList;
            Console.WriteLine(resultIntList.ToString());
            //Console.WriteLine(firstIntList.Capacity);
            //Console.WriteLine(firstIntList.Count);
            //Console.WriteLine(firstIntList[0]);
        }
        public static bool AreEqual<T>(T num1, T num2) where T : IComparable<T>
        {
            return num1.CompareTo(num2) == 0;
        }
        public static T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
