using System;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(5, 4);
            Circle c1 = new Circle(10);
            Shape[] s1 = { r1 ,c1};
            Console.WriteLine("Total Area : "+new AreacCalculator().TotalArea(s1));
        }
    }
    /*Single Prin*/
    public class AreacCalculator
    {
        public double TotalArea(Shape[] shapes)
        {
            double totalArea = 0;
            foreach (var item in shapes)
                totalArea += item.Area();
            return totalArea;
        }
    }
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double height,double width)
        {
            Height = height;
            Width = width;
        }
        public override double Area()
        {
            return Height * Width;
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
