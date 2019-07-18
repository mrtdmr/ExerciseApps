using System.Drawing;

namespace ExtensionMethods2
{
    static class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 5,3,2,4,8,10,45,84,7,1};
            //array.Reverse();
            //Console.WriteLine(string.Join(", ", array));
            //array.Sort(true);
            //Console.WriteLine(string.Join(", ",array));
            Point pointOne = new Point(20,30);
            Point pointTwo = new Point(10, 15);
            pointOne.DistanceTo(pointTwo);
        }
    }
    public class Distance
    {
        public int XDistance { get; set; }
        public int YDistance { get; set; }
    }
}
