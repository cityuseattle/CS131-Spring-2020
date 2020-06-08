using System;

namespace GenericType
{
    class MainClass
    {
        // Declaring class StoreAnything using generic type
        class StoreAnything<T, U, V>
        {
            public T var1 { set; get; }
            public U var2 { set; get; }
            public V var3 { set; get; }
        }

        public static void Main(string[] args)
        {
            // Create new object of class StoreAnything and pass a string type
            StoreAnything<string, int, string> MyVar1 = new StoreAnything<string, int, string> { var1 = "CS", var2 = 131, var3 = "!" };

            Console.WriteLine(MyVar1.var1 + " " + MyVar1.var2 + MyVar1.var3);
        }
    }
}
