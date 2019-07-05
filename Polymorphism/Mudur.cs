namespace Polymorphism
{
    public class Mudur : Calisan
    {
        public Mudur(decimal maas) 
            : base(maas)
        {

        }
        public override decimal ZamYap(decimal zamMiktar)
        {
            decimal ekZam = 2500;
            return base.ZamYap(zamMiktar + ekZam);
        }
    }
}
