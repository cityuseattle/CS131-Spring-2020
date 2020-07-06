using System;
using System.Threading;

namespace CalCircleArea
{
    class Shapes
    {
        public double radius;
        public double Pi;

        public double CalArea(double r, double π)
        {
            radius = r;
            Pi = π;
            double Area = r * r * π;
            return Area;
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            double CirRadius = 3;
            double CirPi = 3.15;
            Shapes Circle = new Shapes();

            Console.WriteLine("Area of CircleSquare is " + Circle.CalArea(CirRadius, CirPi));
        }
    }
}
