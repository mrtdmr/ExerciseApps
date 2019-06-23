using Extensions;
using System;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        // Hazır sınıflara, yapılarını ve kodlarını değiştirmeden metod eklememizi sağlar.
        static void Main(string[] args)
        {
            string post = "This is supposed to be very long post....";
            Console.WriteLine(post.Shorten(3));
            
        }
    }
    
}
namespace Extensions
{
    public static class StringExtensions
    {
        public static string Shorten(this string str, int numberofWords)
        {
            if (numberofWords < 0)
                throw new ArgumentOutOfRangeException("number should be greater than zero or equal to zero.");
            if (numberofWords == 0)
                return "";
            var words = str.Split(' ');
            if (words.Length <= numberofWords)
                return str;
            return string.Join(" ", words.Take(numberofWords)) + "...";
        }
    }
}

