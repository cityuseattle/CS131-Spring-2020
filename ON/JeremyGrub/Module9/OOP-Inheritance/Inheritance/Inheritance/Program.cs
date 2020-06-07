using System;

namespace Inheritance
{
    class Program
    {
        class Shapes //Create class named Shapes with below properties 
        {
            public double length;
            public double width;
            public double radius;

            public void ShowBaseInfo(Rectangle MyRec, Circle MyCir)
            {
                Console.WriteLine("Base length is " + MyRec.length);
                Console.WriteLine("Base width is " + MyRec.width);
                Console.WriteLine("Base radius is" + MyCir.radius);
                Console.WriteLine("\n");
            }
        }
        class Rectangle : Shapes //Rectangle class derived from Shapes base class
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

        class Square : Shapes //Square class derived from Shapes base class
        {
            public void CalArea(double a)
            {
                length = a;
                double SqArea = a * a;
                Console.WriteLine("Square side length is: " + a);
                Console.WriteLine("Square Area is: " + SqArea);
            }
        }

        class Circle : Shapes //Circle class derived from Shapes base class 
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
            Rectangle MyRec = new Rectangle(); //object MyRec of class Rectangle

            Circle MyCir = new Circle(); //object MyCir of class Circle

            Square MySq = new Square(); //object MySqr of class Square

            //using objects to call properties of it classes. Since all Rectangle, Square and Circle classes
            //are derived from baseclass Shapes, all of those classes have access to Shapes' properties
            //maiking their objects also able access
            //length, width an radius, which are the properties of base class Shapes
            //Console.WriteLine("Base length is " + MyRec.length);
            //Console.WriteLine("Base width is " + MyRec.width);
            //Console.WriteLine("Base radius is" + MyCir.radius);
            //Console.WriteLine("\n"); //jump to next line

            MyRec.CalArea(3, 4);
            Console.WriteLine("\n"); //jump to next line

            MySq.CalArea(10);
            Console.WriteLine("\n"); //jump to next line

            MyCir.CalArea(8);
        }
        
    }
}
