using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product p = new Product();
        }
    }
    interface IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
    interface IEntity : IModel
    {
    }
    abstract class Model : IEntity
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    class Product : Model
    {

    }
}
