using System;
using System.Reflection.Metadata;

namespace Class_Object
{
        class Shapes //Create a class named shapes with below properties
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
            public double CalCircleArea(double r)
            {
                radius = r;

                double circleArea = (r * r) * 3.15;
                return circleArea;
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
                

                Shapes Rectangle = new Shapes(); //Create instance/object of class Shapes, named Rectangle
                Shapes Square = new Shapes(); //Create instance/object of class Shapes, named Square
                Shapes Circle = new Shapes();

                //use Object Rectangle to call method CalArea of class Shapes
                Console.WriteLine("Area of Rectangle is: " + Rectangle.CalArea(RecLength, RecWidth));

                //use Object Square to call method CalArea of class Shapes
                Console.WriteLine("Area of Square is: " + Square.CalArea(SqWidth, SqWidth));

            Console.WriteLine("Area of Circle is: " + Circle.CalCircleArea(CirRadius)); 
            }
        }
    
}
