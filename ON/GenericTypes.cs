using System;

namespace GenericTypes
{
    class Program
    {
        //class StoreInt
        //{
        //    public int num1 { set; get; }
        //    public int num2 { set; get; }
        //}

        //class StoreString
        //{
        //    public string strg1 { set; get; }
        //    public string strg2 { set; get; }
        //}

        //static void Main(string[] args)
        //{
        //    StoreInt MyInt = new StoreInt { num1 = 1, num2 = 3 };
        //    StoreString MyStrg = new StoreString { strg1 = "CS", strg2 = "131" };

        //    Console.WriteLine(MyInt.num1 +"," + MyInt.num2);
        //    Console.WriteLine(MyStrg.strg1 + " " + MyStrg.strg2);
        }

        //class StoreAnything<T>
        //{
        //    public T var1 { set; get; }
        //}

        //static void Main(string[] args)
        //{
        //    StoreAnything<string> MyVar1 = new StoreAnything<string> { var1 = "CS'" };
        //    StoreAnything<int> MyVar2 = new StoreAnything<int> { var1 = 131 };

        //    Console.WriteLine(MyVar1 + " " + MyVar2.var1);
        //}

        class StoreAnything<T,U>
        {
            public T var1 { set; get; }
            public U var2 { set; get; }
            public I var3 { set; get; }
        }

        static void Main(string[] args)
        {
            StoreAnything<string,int> MyVar1 = new StoreAnything<string, int,string> { var1 = "CS'", var2 = 131, var3 ="!"};
           
            Console.WriteLine(MyVar1.var1 + MyVar1.var2+MyVar1.var3);
        }
    }
}