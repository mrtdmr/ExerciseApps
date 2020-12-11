using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            //LINQ Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            //LINQ extension methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            //var book = books.Single(b => b.Title == "ASP.NET MVC++");//Burada patlayacaktır. Single tek bir sonuç arar. Birden çok sonuç dönerse de patlar.
            //var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");//returns null
            //var book = books.First(b => b.Title == "C# Advanced Topics");
            //var bookLast = books.Last(b => b.Title == "C# Advanced Topics");
            //Console.WriteLine(book.Title+" "+book.Price+"\n"+ bookLast.Title + " " + bookLast.Price);

            var pagedBooks = books.Skip(2).Take(3);
            foreach (var b in pagedBooks)
            {
                Console.WriteLine(b.Title);
            }
            var count = books.Count();
            var maxBook = books.Max(b => b.Price);
            var minBook = books.Min(b => b.Price);
            var total = books.Sum(b => b.Price);
            //Console.WriteLine(maxBook);
            //Console.WriteLine(minBook);
            //Console.WriteLine(total);


        }
    }
    class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }
    class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book> {
                new Book{Title="Ado.Net Step By Step",Price=5},
                new Book{Title="ASP.NET MVC",Price=9.99f},
                new Book{Title="ASP.NET Web Api",Price=12},
                new Book{Title="C# Advanced Topics",Price=7},
                 new Book{Title="C# Advanced Topics",Price=13}
            };
        }
    }
}
