using System;

namespace Delegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            Yonetim yonetim = new Yonetim();
            InsaataBasla ınsaataBasla = new InsaataBasla();
            Yonetim.InsaatHandler handler = ınsaataBasla.DuvarOr;
        }
        class Yonetim
        {
            public delegate void InsaatHandler(Bina bina);
            public void Basla(InsaatHandler insaatHandler)
            {
                var bina = Bina.TemelAt();
                insaatHandler(bina);
            }
        }
        class InsaataBasla
        {
            public void DuvarOr(Bina bina)
            {
                Console.WriteLine("Duvarlar örülüyor...");
            }
            public void SivaYap(Bina bina) {
                Console.WriteLine("Sıva yapılıyor...");
            }
        }
        class Bina
        {
            public static Bina TemelAt()
            {
                return new Bina();
            }
        }
    }
}
