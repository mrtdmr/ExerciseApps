using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new GenericList<int>();
            //numbers.Add(10);
            //var books = new GenericList<Book>();
            //books.Add(new Book());
            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("24874", new Book());
            //var number = new Nullable<int>();
            //Console.WriteLine("Has value? "+number.HasValue);
            //Console.WriteLine("Value " + number.GetValueOrDefault());
            Person p1 = new Person() { Age = 2 };
            Person p2 = new Person();
            Console.WriteLine(AreEqual(p1, p2));
        }
        public static bool AreEqual<T>(T t1, T t2) where T : IComparable<T>
        {
            return t1.CompareTo(t2) == 0;
        }
    }
    public class Person : IComparable<Person>
    {
        public int Age { get; set; }
        public int CompareTo(Person other)
        {
            return Age == other.Age ? 0 : Age < other.Age ? -1 : 1;
        }
    }
    public class List
    {
        public void Add(int number) { }
        public int this[int index] { get { throw new NotImplementedException(); } }
    }
    public class Book : Product
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
