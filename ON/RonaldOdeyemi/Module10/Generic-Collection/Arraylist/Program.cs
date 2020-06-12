using System;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrList = new ArrayList();

            myArrList.Add(10);
            myArrList.Add(11.5);
            myArrList.Add("This is a String");

            myArrList.AddRange(new ArrayList() { 20, 17.7, "This is another String" });

            myArrList.Remove(10);
            myArrList.RemoveAt(0);
            myArrList.RemoveRange(1, 2);

            foreach (var value in myArrList)
            {
                Console.WriteLine(value);
            }
        }
    }
}
