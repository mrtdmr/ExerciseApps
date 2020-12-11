using System;

namespace Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 6;
            //Console.WriteLine($"{sayi} faktoriyel = {Faktoriyel(sayi)}");
            /*int x = 3, y = 5;
            
            Console.WriteLine($"x : {x}\ny : {y}");
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine($"x : {x}\ny : {y}");*/
            

        }
        static int Faktoriyel(int sayi)
        {
            if (sayi == 0)
                return 1;
            return sayi * Faktoriyel(sayi - 1);
        }
    }
}
