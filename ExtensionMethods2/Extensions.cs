using System;
using System.Drawing;

namespace ExtensionMethods2
{
    public static class Extensions
    {
        public static void Sort(this int[] array) // extension metodlar sadece static sınıflar içinde tanımlanabilir. Bu örnekte sadece int tipinde arraylerde çalışır.
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public static void Sort(this int[] array, bool reverse = false) // extension metodlar sadece static sınıflar içinde tanımlanabilir. Bu örnekte sadece int tipinde arraylerde çalışır.
        {
            array.Sort();
            if (reverse)
            {
                Array.Reverse(array);
            }
        }
        public static void Reverse(this int[] array)
        {
            Array.Reverse(array);
        }
        public static Distance DistanceTo(this Point p1, Point p2)
        {
            Console.WriteLine($"Teh distance between P1 and P2 is:" +
                $"\n{p2.X - p1.X} units in the X direction" +
                $"\n{p2.Y - p1.Y} units in the Y direction");

            return new Distance() { XDistance = p2.X - p1.X, YDistance = p2.Y - p1.Y };
        }
    }
}
