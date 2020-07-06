using System;

namespace GnericTypes2
{
    class Program
    {
        class StoreAnything <T, U, F>
        {
            public T var1 { set; get; }
            public U var2 { set; get; }
            public F var3 { set; get; }
        }
        static void Main(string[] args)
        {
            StoreAnything<string, int,string > MyVar1 = new StoreAnything<string, int,string  > { var1 = "CS", var2 = 131, var3 = "!" };

            Console.WriteLine(MyVar1.var1 + "" + MyVar1.var2 + MyVar1.var3);
        }
    }
}
