using System;

namespace OOPInheritance
{
    class MainClass
    {
        // Create a class named Shapes with the following properties
        // Parent class or base class
        class Shapes
        {
            public double length;
            public double width;
            public double radius;
        }

        // Rectangle class derived from Shapes base class
        // Child class
        class Rectangle : Shapes
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

        // Sqaure class derived from Shapes base class
        // Child class
        class Square : Shapes
        {
            public void CalArea(double a)
            {
                length = a;

                double SqArea = a * a;

                Console.WriteLine("Square side lenght is: " + length);
                Console.WriteLine("Square area is: " + SqArea);
            }
        }

        class Circle : Shapes
        {
            public void CalArea(double r)
            {
                radius = r;

                double CirArea = 3.14 * r * r;

                Console.WriteLine("Circle radius is: " + radius);
                Console.WriteLine("Circle area is: " + CirArea);
            }
        }
        public static void Main(string[] args)
        {
            // Object MyRec of class Rectangle
            Rectangle MyRec = new Rectangle();

            // Object MyCir of class Circle
            Circle MyCir = new Circle();

            //Object MySq of class Square
            Square MySq = new Square();

            // Use objects to call properties of its classes
            // Since Rectangle, Square, and Circle classes are derived from base class Shapes
            // All of those have access to Shapes' properties length, width, and radius
            Console.WriteLine("Base length is: " + MyRec.length);
            Console.WriteLine("Base width is: " + MyRec.width);
            Console.WriteLine("Base radius is: " + MyCir.radius);
            Console.WriteLine("\n");

            MyRec.CalArea(3, 4);
            Console.WriteLine("\n");

            MySq.CalArea(10);
            Console.WriteLine("\n");

            MyCir.CalArea(8);
        }
    }
}
