namespace DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// Prototype
    /// </summary>
    abstract class Prototype
    {
        public abstract Prototype Clone();
    }
    /// <summary>
    /// Concrete Prototype
    /// </summary>
    class Product : Prototype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal ListPrice { get; set; }
        public Product(int id, string name, decimal listPrice)
        {
            Id = id;
            Name = name;
            ListPrice = listPrice;
        }

        public override Prototype Clone()
        {
            return MemberwiseClone() as Prototype;
        }
    }
    class Person : Prototype
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public override Prototype Clone()
        {
            return MemberwiseClone() as Prototype;
        }
    }
}
