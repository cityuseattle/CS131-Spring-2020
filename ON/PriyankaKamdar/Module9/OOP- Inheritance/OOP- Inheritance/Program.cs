using System;
using System.ComponentModel.DataAnnotations;

namespace OOP__Inheritance
{
    class Program
    {
        class Shapes                         //class name created with below mention properties
        {
            public double length;
            public double width;
            public double radius;

            public void PrintProperties()
            {
                Console.WriteLine("Base length is " + length);
                Console.WriteLine("Base length is " + width);
                Console.WriteLine("Base radius is " + radius);
                Console.WriteLine("\n");

            }
        }

        class Rectangle : Shapes           // Rectangle class derived from shapes
        {
            public void CalArea(double l, double w)
            {
                length = l;
                width = w;
                double RecArea = l * w;
                Console.WriteLine("Rectangle length is: " + length);
                Console.WriteLine("Rectangle width is: " + width);
                Console.WriteLine("Rectangle Area is: " + RecArea);
            }         
        }

        class Square : Shapes            // Square class derived from Shapes base class
        {
            public void CalArea(double a)
            {
                length = a;
                double SqArea = a * a;
                Console.WriteLine("Square side length is: " + a);
                Console.WriteLine("Square Area is: " + SqArea);
            }
        }

        class Circle : Shapes
        { 
         public void CalArea(double r)
            {
                radius = r;
                double CirArea = 3.15 * r;
                Console.WriteLine("Circle radius is: " + radius);
                Console.WriteLine("Circle Area is: " + CirArea);
            }
        }

        static void Main(string[] args)
        {
            Rectangle MyRec = new Rectangle();          // Object MyRec of class Rectangle
            Circle MyCir = new Circle();                // Object MyRec of class Circle
            Square MySq = new Square();                 // Object MyRec of class Square


            MyRec.PrintProperties();
            MyRec.CalArea(3, 4);
            Console.WriteLine("\n");

            MySq.CalArea(10);
            Console.WriteLine("\n");

            MyCir.CalArea(8);
        }
    }
}