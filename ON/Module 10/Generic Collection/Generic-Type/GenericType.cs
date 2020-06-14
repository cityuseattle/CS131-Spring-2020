using System;

namespace Generic_Type
{
    class Program
    {
        class StoreAnything <T, U, I> //declare class StoreAnything using generic type
        {
            public T var1 { get; set; }
            public U var2 { get; set; }
            public I var3 { get; set; }
        }

        static void Main(string[] args)
        {
            //create new object of StoreAnything class, passing string and int type and char type
            StoreAnything<string, int, char> MyVar1 = new StoreAnything<string, int, char> { var1 = "CS", var2 = 131, var3 = '!'};

            Console.WriteLine(MyVar1.var1 + " " + MyVar1.var2 + "" + MyVar1.var3); //print new values of var1 and var2
            
        }
    }
}
