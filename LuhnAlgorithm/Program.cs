using System;

namespace LuhnAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string kartNo = "";
            int tekToplam = 0, ciftToplam = 0, carp;
            Console.WriteLine("Kredi Kartı Numaranızı Giriniz :");
            kartNo = Console.ReadLine();
            for (int i = 0; i < kartNo.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                    ciftToplam += int.Parse(kartNo[i].ToString());
                else
                {
                    carp = int.Parse(kartNo[i].ToString()) * 2;
                    if (carp < 10)
                        tekToplam += carp;
                    else
                    {
                        tekToplam += int.Parse(carp.ToString().Substring(0, 1));
                        tekToplam += int.Parse(carp.ToString().Substring(1, 1));
                    }
                }
            }
            Console.WriteLine("{0}", (tekToplam + ciftToplam) % 10 == 0 ? "Uygun Kart." : "Yanlış Kart");
        }
    }
}
