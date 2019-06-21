using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    class Program
    {
        // an anonymous method that no access modifier, no name, no return statement
        // for less code, more readable
        static void Main(string[] args)
        {
            //args => expression
            //number => number * number;
            //()=>...
            //x=>...
            //(x,y,z)=>...

            //Func<int, int> square = number => number * number;
            //Console.WriteLine(square(5));

            //const int factor = 5;
            //Func<int, int> multipler = n => n * factor;
            //Console.WriteLine(multipler(10));

            var books = new Bookrepository().GetBooks();
            //var cheapBooks =books.FindAll(IsCheaperThen10Dollars);
            var cheapBooks = books.FindAll(b => b.Price < 10);
            foreach (var item in cheapBooks)
            {
                Console.WriteLine(item.Name);
            }
        }
        static bool IsCheaperThen10Dollars(Book book)//Predicate method
        {
            return book.Price < 10;
        }
    }
    class Bookrepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Id=1,Name="Book 1",Price=5},
                new Book{Id=2,Name="Book 2",Price=7},
                new Book{Id=3,Name="Book 3",Price=17}
            };
        }
    }
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
