using System;

namespace GenericType1
{
    class Program
    {
        internal class StoreAnything<T1, T2, T3>
        {
            public string var1 { get; set; }
            public int var2 { get; set; }
            public object var3 { get; set; }

        

        }
        static void Main(string[] args)
        {
            StoreAnything<string, int, object> MyVar1 = new StoreAnything<string, int, object> {var1 = "CS", var2 = 131, var3 = !};


            Console.WriteLine(MyVar1.var1 + " " + MyVar1.var2 + MyVar1.var3); 
        }

    }

    
}