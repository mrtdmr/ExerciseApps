namespace Polymorphism
{
    class Baskan : Calisan
    {
        public Baskan(decimal maas)
            : base(maas)
        {

        }
        public override decimal ZamYap(decimal zamMiktari)
        {
            return base.ZamYap(zamMiktari);
        }
    }
}
