using System;

namespace GenericType
{
    class MainClass
    {
        // Declaring class StoreAnything using generic type
        class StoreAnything<T, U>
        {
            public T var1 { set; get; }
            public U var2 { set; get; }
        }

        public static void Main(string[] args)
        {
            // Create new object of class StoreAnything and pass a string type
            StoreAnything<string, int> MyVar1 = new StoreAnything<string, int> { var1 = "CS", var2 = 131 };

            Console.WriteLine(MyVar1.var1 + " " + MyVar1.var2);
        }
    }
}
