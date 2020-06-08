using System;

namespace Inheritance
{
    class Program
    {
        class Shapes
        {
            public double length;
            public double width;
            public double radius;
        }

        class Rectangle : Shapes
        {
            public void CalArea(double l, double w)
            {
                double length = l;
                double width = w;
                double RecArea = l * w;
                Console.WriteLine("Rectangle length is: " + length);
                Console.WriteLine("Rectangle width is: " + width);
                Console.WriteLine("Rectangle Area is: " + RecArea);
            }
        }

        class Square : Shapes
        {
          public void CalArea(Double a)
            {
                double length = a;
                double SqArea = a * a;
                Console.WriteLine("Square side length is: " + a);
                Console.WriteLine("Square Area is: " + SqArea);
            }
        }

        class Circle : Shapes
        {
            public void CalArea(double r)
            {
                double radius = r;
                double CirArea = 3.15 * r;
                Console.WriteLine("Circle radius is: " + radius);
                Console.WriteLine("Circle Area is: " + CirArea);
            }
        }

        static void Main(string[] args)
        {
            Rectangle MyRec = new Rectangle();
            Circle MyCir = new Circle();
            Square MySq = new Square();

            Console.WriteLine("Base Length is " + MyRec.length);
            Console.WriteLine("Base width is " + MyRec.width);
            Console.WriteLine("Base radius is " + MyCir.radius);
            Console.WriteLine("\n");

            MyRec.CalArea(3, 4);
            Console.WriteLine("\n");

            MySq.CalArea(10);
            Console.WriteLine("\n");

            MyCir.CalArea(8);

        }
    }
}
