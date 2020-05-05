using System;

namespace Yi_RefVal
{
    class Program
    {
        static void Main()
        {
            string name = "Lilly";
            float years= 5.5f;
            float tall = 46.5f;
            
            //Write out the initial variables
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + years + " years old");
            Console.WriteLine("Height: " + tall + " inches tall");
            
            //Call the reference for new data
            GrowingUp(ref name, ref years, ref tall);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + years + " years old");
            Console.WriteLine("Height: " + tall + " inches tall");
        }
        
        //This method, although age and height don't grow at an equal rate,
        //takes into fact that often times age and height are relational.
        static void GrowingUp(ref string NAME, ref float AGE, ref float HEIGHT)
        {
            const float rate = 1.05f;
            NAME = "Lillian";
            AGE *= rate;
            HEIGHT *= rate;
        }

    }
}