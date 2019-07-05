using System;

namespace Delegates
{
    class Program
    {
        // Metod referansı olarak tanımlanabilirler. Metodları nasıl çağıracaklarını bildiren nesnelerdir. Alternatif olarak interface kullanılabilir.
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;
            processor.Process("", filterHandler);
        }
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Applying remove red eye.");
        }
    }
    class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applying brightness...");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applying contrast...");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo...");
        }
    }
    class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }
        public void Save() { }
    }
    class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo);
        //public void Process(string path,PhotoFilterHandler filterHandler)
        //{
        //    //System.Action<> 
        //    //System.Func<>
        //    // Func deleagte geri dönüş yapar. Action yapmaz
        //    var photo = Photo.Load(path);
        //    filterHandler(photo);
        //    photo.Save();
        //}
        public void Process(string path, Action<Photo> filterHandler)
        {
            //System.Action<> 
            //System.Func<>
            // Func deleagte geri dönüş yapar. Action yapmaz
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }
    }
}
