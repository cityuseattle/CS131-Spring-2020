using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;

namespace Class_Object
{

    class Shapes
    {
        public double length;
        public double width;
        public double radius;

        
        public double CalArea(double l, double w)
        {
            length = l;
            width = w;
            double Area = length * width;
            return Area;
        }
                
        public double CalCircleArea(double r)
        {
            const double pie = 3.15;
            radius = r;
            double Area = pie * radius * radius;
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
            double CirRadius = 3;

            Shapes Rectangle = new Shapes();
            Shapes Square = new Shapes();
            Shapes Circle = new Shapes();

            Console.WriteLine("Area of Rectangle is:  " + Rectangle.CalArea(RecLength, RecWidth));
            Console.WriteLine("Area of Square is: " + Square.CalArea(SqWidth, SqWidth));
            Console.WriteLine("Area of Circle is: " + Circle.CalCircleArea(CirRadius).ToString("N2"));

        }
    }
}
