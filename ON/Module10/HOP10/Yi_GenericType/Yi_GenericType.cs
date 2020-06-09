using System;

namespace Yi_GenericType
{
    class Program
    {
        class StoreAnything<T, U, V> //declare class StoreAnything using generic type
        {
            public T var1 { set; get; }
            public U var2 { set; get; }
            public V var3 { set; get; }
        }
        

        static void Main(string[] args)
        {
            //Create new object of StoreAnything class, passing string and int type
            StoreAnything<string, int, char> MyVar1 
                = new StoreAnything<string, int, char> {var1 = "CS", var2 = 131, var3 = '!'};

            Console.WriteLine($"{MyVar1.var1}{MyVar1.var2}{MyVar1.var3}"); //print new values of var1 and var2
        }
    }
}