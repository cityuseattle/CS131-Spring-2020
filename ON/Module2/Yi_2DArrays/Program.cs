using System;

namespace Yi_2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 3;

            int[,] table = new int[rows, columns]; //create a 2d array that is 3x3 (3 rows and 3 columns)
            table[0, 0] = 1; //assign value to each array element, no specific value is provided, by default it's 0
            table[0, 1] = 2;
            table[0, 2] = 3;
            table[1, 1] = 5; //For the challenge
            table[2, 1] = 8;
            
            //loop through and print the whole array
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Console.Write(table[x, y]);
                }

                Console.WriteLine(); //a new line is created after each row is iterated
            }
        }
    }
}