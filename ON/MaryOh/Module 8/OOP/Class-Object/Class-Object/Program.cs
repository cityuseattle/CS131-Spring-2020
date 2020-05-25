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
    }

    class Program
    {
        static void Main(string[] args)
        {
            double RecWidth = 7;
            double RecLength = 8;
            double SqWidth = 2;

            // Create an instance/object of class Shapes called Rectangle
            Shapes Rectangle = new Shapes();
            // Create an instance/object of class Shapes called Square
            Shapes Square = new Shapes();

            // Use object Rectangle to call method CalArea of class Shapes
            Console.WriteLine("Area of rectangle is: " + Rectangle.CalArea(RecLength, RecWidth));

            // Use object Square to call method CalArea of class Shapes
            Console.WriteLine("Area of square is: " + Square.CalArea(SqWidth, SqWidth));
        }
    }
}
