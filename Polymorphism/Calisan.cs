﻿namespace Polymorphism
{
    public class Calisan
    {
        public decimal Maas { get; set; }
        public Calisan(decimal maas)
        {
            Maas = maas;
        }
        public virtual decimal ZamYap(decimal zamMiktari)
        {
            return Maas += zamMiktari;
        }
    }
}
