using System;

namespace OOP_Inheritance
{
    class Program
    {

        class Shapes
            // create class named Shapes with below parameters
        {
            public double length;
            public double width;
            public double radius;

            public void DisplayBaseProperties()
            {
                Console.WriteLine("Length is : " + length);
                Console.WriteLine("Width is : " + width);
                Console.WriteLine("Radius is : " + radius);

            }
        }

        class Rectangle: Shapes
            // rectangle class derived from Shapes base class
        {
            public void CalArea(double l, double w)
            {
                length = l;
                width = w;
                double RecArea = l * w;
                Console.WriteLine("Rectangle length is: " + length);
                Console.WriteLine("Rectangle width is: " + width);
                Console.WriteLine("Rectangle area is: " + RecArea);
            }

        }

        class Square : Shapes
            // square class derived from shapes base class
        {
            public void CalArea(double a)
            {
                length = a;
                double SqArea = a * a;
                Console.WriteLine("Square side length is: " + a);
                Console.WriteLine("Square area is: " + SqArea);
            }

        }

        class Circle : Shapes
            // circle class dervied from shapes base class
        {
            public void CalArea(double r)
            {
                radius = r;
                double CirArea = 3.15 * r;
                Console.WriteLine("Circle radius is: " + radius);
                Console.WriteLine("Circle area is: " + CirArea);
            }

        }
        static void Main(string[] args)
        {
            Rectangle MyRec = new Rectangle();
            Circle MyCir = new Circle();
            Square MySq = new Square();

            //Console.WriteLine("Base length is " + MyRec.length);
            //Console.WriteLine("Base width is " + MyRec.width);
            //Console.WriteLine("Base radius is " + MyCir.radius);
            //Console.WriteLine("\n");

            MyRec.CalArea(3, 4);
            Console.WriteLine("\n");

            MySq.CalArea(10);
            Console.WriteLine("\n");

            MyCir.CalArea(8);

            //  call .DisplayBaseProperties() on Circle class and
            //  receive the same output as lines 70-72
            MyCir.DisplayBaseProperties();
        }
    }
}
