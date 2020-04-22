using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aryString = new string[4]; //creating new array of type String named aryString
            aryString[0] = "This";
            aryString[1] = "is";
            aryString[2] = "a";
            aryString[3] = "string";
          

            //print out the whole array
            //for (int i = 0; i <aryString.Length; i++)
            //{
            //      Consoler.Write(aryString[i] + " ");
            //}

            foreach (string i in aryString)
            {
                Console.Write(i + " ");
            }

        }
    }
}
