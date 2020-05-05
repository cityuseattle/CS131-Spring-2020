using System;

namespace Yi_ScopeLevels
{
    class Program
    {
        static int number = 9000;
        
        static void Main()
        {
            Console.WriteLine("Class level: "+ number); //This shows the Class level Scope
            
            //Here I call the method, to display method level and block level Scopes
            METHODANDBLOCK();
            Console.ReadLine();
        }

        static void METHODANDBLOCK()
        {
            //Test for block level 
            const bool test = true;
            
            int number = 5000;
            Console.WriteLine("Method level: " + number); //This shows the method level scope

            if (test) //Creates conditional 
            {
                number = 2500;
                Console.WriteLine("Block level: " + number); //This shows the block level scope
                
            }
        }
    }
}