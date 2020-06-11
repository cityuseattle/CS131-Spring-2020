using System;
using System.Reflection.Metadata;

namespace GenericType
{
    class Program
    {
        class StoreAnything<T, U, V> //declare class StoreAnything using generic trype
        {
            public T var1 {set; get; }
            public U var2 { set; get; }
            public V var3 { set; get; }
        }
        static void Main(string[] args)
        {
            //create new object of StoreAnything class, passing string and int type
            StoreAnything<string, int, string> MyVar1 = new StoreAnything<string, int, string> { var1 = "CS", var2 = 131, var3 = "!" };

            Console.WriteLine(MyVar1.var1 + MyVar1.var2 + MyVar1.var3); //print new values of var1 and var2
        }
    }
}
