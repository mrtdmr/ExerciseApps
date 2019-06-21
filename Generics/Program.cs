using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(10);
            var books = new GenericList<Book>();
            books.Add(new Book());
            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("24874", new Book());
            var number = new Nullable<int>();
            Console.WriteLine("Has value? "+number.HasValue);
            Console.WriteLine("Value " + number.GetValueOrDefault());
        }
    }
    public class List
    {
        public void Add(int number) { }
        public int this[int index] { get { throw new NotImplementedException(); } }
    }
    public class Book:Product
    {
        public string Isbn { get; set; }
    }
    public class BookList
    {
        public void Add(Book book)
        { }
        public Book this[int index] { get { throw new NotImplementedException(); } }
    }

    /*Her defasında yeni bir tip için yeni bir liste tipi oluşturmak gerekli bu yapıda. Object tipi kullanılabilir. Fakat bu da performans sorununa yol açabilir. (Boxing-unboxing)*/
    public class ObjectList
    {
        public void Add(object value)
        { }
        public Object this[int index] { get { throw new NotImplementedException(); } }
    }

    //Generics
    public class GenericList<T> //T:Template
    {
        public void Add(T value) { }
        public T this[int index] { get { throw new NotImplementedException(); } }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }
}
