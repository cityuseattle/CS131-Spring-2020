using System;

namespace Yi_ClassObject
{
    class Shapes //Create class named Shapes with below properties
    {
        public double length;
        public double width;
        public double radius;

        public double CalArea(double l, double w)
        {
            length = l;
            width = w;
            double area = w * l;
            return area;
        }
        
        //Create a method that calculates the area of a circle
        public double CalCirArea(double r)
        {
            radius = r;
            double pi = 3.15;
            double area = pi * r * r;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double RecWidth = 7;
            double RecLength = 8;
            double SqWidth = 2;
            double Rad = 3; //Radius set for challenge question

            Shapes Rectangle = new Shapes(); // Create instance/object of class Shapes, named Rectangle
            Shapes Square = new Shapes(); //Create instance/object of class Shapes, named Square
            Shapes Circle = new Shapes(); //Creates Circle instance of class shapes
            
            //Use Object Rectangle to call method CalArea of class shapes
            Console.WriteLine($"Area of rectangle is: {Rectangle.CalArea(RecLength,RecWidth)}");
            
            //Use Object Square to call method CalArea of class Shapes
            Console.WriteLine($"Area of Square is: {Square.CalArea(SqWidth,SqWidth)}");
            
            //Use Object Circle to call method CalCirArea of class Shapes
            Console.WriteLine($"Area of a circle is: {Circle.CalCirArea(Rad)}");
        }
    }
}