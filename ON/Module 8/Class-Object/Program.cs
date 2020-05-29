using System;

namespace Class_Object
{
    class Program
    {
        //create class named shapes with the below properties
        class Shapes 
        {
            public double length;
            public double width;
            public double radius;

            // create member method Calculate area
            public double CalArea(double l, double w)
            {
                length = l;
                width = w;
                double Area = w * l;
                return Area;
            }
            // create member method Calulate Circle Area
            public double CalCircleArea(int r)
            {
                radius = r;
                double area = (3.15) * r * r;
                // output will be 28.349999999999998 without calling Math.Round()
                return Math.Round(area, 2);
            }
        }

        static void Main(string[] args)
        {
            double RecWidth = 7;
            double RecLength = 8;
            double SqWidth = 2;
            int Radius = 3;

            Shapes Rectangle = new Shapes(); //create instance/object of class Shapes, named Rectangle
            Shapes Square = new Shapes(); //create instance/object of class Shapes, named Rectangle
            Shapes Circle = new Shapes(); //create instance/object of class Shapes, named Circle


            //use object Rectangle to all method CalArea of class Shapes
            Console.WriteLine("Area of Rectangle is: " + Rectangle.CalArea(RecLength, RecWidth));

            //use object Square to call method CalArea of class Shapes
            Console.WriteLine("Area of Square is: " + Square.CalArea(SqWidth, SqWidth));

            //use object Circle to call method CalCircleArea of class Shapes
            Console.WriteLine("Area of Circle is: " + Circle.CalCircleArea(Radius));
        }
    }
}
