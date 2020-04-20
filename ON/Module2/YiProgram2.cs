using System;

namespace CS131
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5]; //creating a new array of type integer named 'numbers'
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            Console.WriteLine(numbers[1]);
        }
    }
}