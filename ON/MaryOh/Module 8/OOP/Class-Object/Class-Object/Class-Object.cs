using System;

namespace ClassObject
{
    // Create a class named Shapes with properties
    class Shapes
    {
        public double lenght;
        public double width;
        public double radius;

        public double CalArea(double l, double w)
        {
            lenght = l;
            width = w;

            double Area = l * w;
            return Area;
        }

        public double CalCircleArea(double r)
        {
            radius = r;
            const double PI = 3.14;

            double Area = PI * r * r;
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
            double rad = 3;

            // Create an instance/object of class Shapes called Rectangle
            Shapes Rectangle = new Shapes();
            // Create an instance/object of class Shapes called Square
            Shapes Square = new Shapes();
            // Create an instance/object of class Shapes called Circle
            Shapes Circle = new Shapes();

            // Use object Rectangle to call method CalArea of class Shapes
            Console.WriteLine("Area of rectangle is: " + Rectangle.CalArea(RecLength, RecWidth));

            // Use object Square to call method CalArea of class Shapes
            Console.WriteLine("Area of square is: " + Square.CalArea(SqWidth, SqWidth));

            // Use object Circle to call method CalCircleArea of class Shapes
            Console.WriteLine("Area of circle is: " + Circle.CalCircleArea(rad));
        }
    }
}
