using System;

namespace Yi_Inheritance
{
    class Program
    {
        class Shapes //Create class named Shapes with below properties
        {
            public double length;
            public double width;
            public double radius;

            public static void BasePprty(double length, double width, double radius)
            {
                Console.WriteLine($"Base length is {length}");
                Console.WriteLine($"Base width is {width}");
                Console.WriteLine($"Base radius is {radius}\n");
            }
        }

        class Rectangle : Shapes //Rectangle class derived from Shapes base class
        {
            public void CalArea(double l, double w)
            {
                length = l;
                width = w;
                double RecArea = l * w;
                Console.WriteLine($"Rectangle length is: {length}");
                Console.WriteLine($"Rectangle width is: {width}");
                Console.WriteLine($"Rectangle area is: {RecArea}");
            }
        }

        class Square : Shapes //Square class derived from Shapes base class
        {
            public void CalArea(double a)
            {
                length = a;
                double SqArea = a * a;
                Console.WriteLine($"Square side length is: {a}");
                Console.WriteLine($"Square area is: {SqArea}");
            }
        }

        class Circle : Shapes //Circle class derived from Shapes base class
        {
            public void CalArea(double r)
            {
                radius = r;
                double CirArea = 3.14 * r * r;
                Console.WriteLine($"Circle radius is: {radius}");
                Console.WriteLine($"Circle area is: {CirArea}");
            }
        }
        
        static void Main(string[] args)
        {
            Rectangle MyRec = new Rectangle(); //object myRec of class Rectangle
            Circle MyCir = new Circle(); //object MyCir of class Circle
            Square MySq = new Square(); // object MySq of class Square
            
            /*Using objects to call properties of its classes. Since all rectangle, square and circle classes 
             *are derived from base class Shapes, all of those classes have access to Shapes' properties
             * making their objects also able to access length, width, and radius, which are the properties of base
             * class Shapes
             */
            Shapes.BasePprty(length: MyRec.length, width: MyRec.width, radius: MyCir.radius);
            

            MyRec.CalArea(3, 4);
            Console.WriteLine("\n");

            MySq.CalArea(10);
            Console.WriteLine("\n");

            MyCir.CalArea(8);
        }
    }
}