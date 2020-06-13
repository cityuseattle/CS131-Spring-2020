using System;

namespace Class_Object
{
    class ShapesC
    {
        public double length;
        public double width;
        public double radius;
        public double CalArea(double l, double w)
        {
            length = l;
            width = w;
            double Area = w * l;
            return Area;
        }
    }

    class Program
    {
            static void Main(string[] args)
        {
            double RecWidth = 7;
            double RecLength = 8;
            double SqWidth = 2;
            double Radius = 3;
            double Pi = 3.15;


            ShapesC Rectangle = new ShapesC();
            ShapesC Square = new ShapesC();
            ShapesC Circle = new ShapesC();
            Console.WriteLine("Area of Rectangle is" + Rectangle.CalArea(RecLength, RecWidth));
            Console.WriteLine("Area of a Square is" + Square.CalArea(SqWidth, SqWidth));
            Console.WriteLine("Area of a Circle is" + Circle.CalCircleArea(Radius, Pi));
        }
    }
}
