using System;
using System.Collections.Generic;

namespace MukemmelSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            int toplam = 0;
            for (int i = 1; i < 1000; i++)
            {
                toplam = 0;
                sayilar.Clear();
                for (int j = i-1; j > 0; j--)
                {
                    if (i % j == 0)
                        sayilar.Add(j);
                }
                foreach (var item in sayilar)
                    toplam += item;
                if (i == toplam)
                    Console.WriteLine(i);
            }
        }
    }
}
