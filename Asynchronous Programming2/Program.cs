using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousProgramming2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Task t = new Task(ConcatenateChars);
            //t.Start();
            int count = 200000;
            char charToConcatenate = '1';
            Task<string> t = Task.Factory.StartNew(() => ConcatenateChars(charToConcatenate, count));
            Console.WriteLine("In Progress..");
            t.Wait();
            Console.WriteLine("Completed");
            Console.WriteLine("The length of the result is "+t.Result.Length);
            */

            int count = 200000;
            char charToConcatenate = '1';
            Task<string> t = ConcatenateCharsAsync(charToConcatenate, count);
            Console.WriteLine("In Progress..");
            Console.WriteLine("The length of the result is " + t.Result.Length);
        }
        /*
        public static string ConcatenateChars(char charToConcatenate, int count)
        {
            string concatenatedString = string.Empty;
            for (int i = 0; i < count; i++)
            {
                concatenatedString += charToConcatenate;
            }
            return concatenatedString;
        }
        */
        public async static Task<string> ConcatenateCharsAsync(char charToConcatenate, int count)
        {
            return await Task<string>.Factory.StartNew(() => {
                return ConcatenateChars(charToConcatenate, count);
            });
        }
        public static string ConcatenateChars(char charToConcatenate, int count)
        {
            string concatenatedString = string.Empty;
            for (int i = 0; i < count; i++)
            {
                concatenatedString += charToConcatenate;
            }
            return concatenatedString;
        }
    }
}
