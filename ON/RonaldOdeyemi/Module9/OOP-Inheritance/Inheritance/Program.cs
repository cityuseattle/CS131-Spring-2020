using Microsoft.CSharp.RuntimeBinder;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Inheritance
{
    class Program
    {
        class Shapes
        {
            public double length;
            public double width;
            public double radius;
           

            public void DisplayBaseProp()
            {
                Console.WriteLine("Base length is: " + length);
                Console.WriteLine("Base width is " + width);
                Console.WriteLine("Base radius is " + radius);
                Console.WriteLine("\n");
            }
        }

        class Rectangle : Shapes

        {
            public void CalArea(double l, double w)
            {
                length = l;
                width = w;
                double RecArea = length * width;
                Console.WriteLine("Rectangle length is: " + length);
                Console.WriteLine("Rectangle width is: " + width);
                Console.WriteLine("Rectange area is: " + RecArea);
            }

           
        }

        class Square : Shapes
        {
            public void CalArea(double a)
            {
                length = a;
                double SqArea = length * length;
                Console.WriteLine("Square side length is: " + length);
                Console.WriteLine("Square Area is " + SqArea);

            }
        }
       
        class Circle : Shapes
        {
            public void CalArea(double r)
            {
                radius = r;
                double CirArea = 3.15 * radius * radius;
                Console.WriteLine("Circle radius is: " + radius);
                Console.WriteLine("Circle Area is " + CirArea);

            }
        }

        static void Main(string[] args)
        {
            Rectangle MyRec = new Rectangle();
            Circle MyCir = new Circle();
            Square MySq = new Square();
            Shapes BaseProp = new Shapes();

            BaseProp.DisplayBaseProp();

            MyRec.CalArea(3, 4);
            Console.WriteLine("\n");

            MySq.CalArea(10);
            Console.WriteLine("\n");

            MyCir.CalArea(8);

        }
    }
}
