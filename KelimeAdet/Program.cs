using System;
using System.Collections.Generic;

namespace KelimeAdet
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle = "Kırk kırık küp. Kırkının da kulpu kırık kara kırık küp.";
            cumle = cumle.Replace(",", "").Replace(".", "");
            string[] kelimeler = cumle.Split(" ");

            int index = 1;
            for (int i = 0; i < kelimeler.Length; i++)
            {
                index = 1;
                if (kelimeler[i] != "")
                {
                    for (int j = i + 1; j < kelimeler.Length; j++)
                    {
                        if (kelimeler[i] == kelimeler[j])
                        {
                            index++;
                            kelimeler[j] = "";
                        }
                    }
                }
                if (kelimeler[i] != "")
                    Console.WriteLine(kelimeler[i] + " " + index);
            }
        }
    }
}
