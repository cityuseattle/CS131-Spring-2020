using System;

namespace GenericType
{
    class Program
    {
        class StoreInt
        {
            public int num1 { set; get; }
            public int num2 { set; get; }
        }
        class StoreString
        {
            public string strg1 { set; get; }
            public string strg2 { set; get; }
        }
        static void Main(string[] args)
        {
            StoreInt MyInt = new StoreInt { num1 = 1, num2 = 3 };
            StoreString Mystring = new StoreString { strg1 = "CS", strg2 = "131" };


            Console.WriteLine(MyInt.num1 + "," + MyInt.num2);
            Console.WriteLine(Mystring.strg1 + " " + Mystring.strg2);
        }
    }
}
