using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader streamReader = null;
            //try
            //{
            //    //var calculator = new Calculator();
            //    //calculator.Divide(5, 0);
            //    streamReader = new StreamReader(@"C:\file.zip");
            //    var content = streamReader.ReadToEnd();
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Sorry, you can not divide by zero.");
            //}
            //catch (ArithmeticException ex)
            //{
            //    Console.WriteLine("Sorry, arithmetic error accurred.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sorry, an unexpected error accurred.");
            //}
            //finally
            //{
            //    if (streamReader!=null)
            //        streamReader.Dispose();
            //}

            //try
            //{
            //    using (var streamReader = new StreamReader(@"C:\file.zip"))//using ile finally bloğu otomatik olarak oluştu ve dispose metodu otomatik çağrıldı.
            //    {
            //        var content = streamReader.ReadToEnd();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sorry, an unexpected error accurred.");
            //}

            try
            {
                var api = new YoutubeApi();
                var videos = api.GetVideos("murat");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Calculator
    {
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
    class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                throw new Exception("Oops youtube error.");
            }
            catch (Exception ex)
            {
                //log
                throw new YoutubeException("Could not fetch the videos from Youtube.", ex);
            }
            return new List<Video>();
        }
    }
    class YoutubeException : Exception
    {
        public YoutubeException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
    class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
