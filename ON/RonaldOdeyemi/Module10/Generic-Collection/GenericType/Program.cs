using System;

namespace GenericType
{
    class Program
    {
        class StoreAnything <T, U, V>
        {    
            public T var1 { set; get; }
            public U var2 { set; get; }

            public V var3 { set; get; }
        }

        static void Main (string [] args)
        {
            StoreAnything<string, int, char> MyVar1 = new StoreAnything<string, int, char> { var1 = "CS", var2 = 131, var3 = '!' };


            Console.WriteLine(MyVar1.var1 + " " + MyVar1.var2 + MyVar1.var3);
        }


    }
}
