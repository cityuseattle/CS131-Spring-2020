using System;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 3;

            int[,] table = new int[rows, columns];
            table[0, 0] = 1;
            table[0, 1] = 2;
            table[0, 2] = 3;
            table[1, 1] = 5;
            table[2, 1] = 8;


            for(int x = 0; x < rows; x++) 
            {
                for(int y = 0; y < columns; y++)
                {
                    Console.Write(table[x,y]);
                }
                Console.WriteLine(); 
            }
        }
    }
}
