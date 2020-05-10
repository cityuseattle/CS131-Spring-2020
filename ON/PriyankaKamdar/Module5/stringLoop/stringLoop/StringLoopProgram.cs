using System;

namespace stringLoop
{
    class StringLoopProgram
    {
        public static void Main()
        {
            string[] colors = new string[] { "Red", "Green", "White", "Pink" };
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine("Element [" + i + "] = " + colors[i]);
            }
            Console.ReadLine();
        }
    }
}
