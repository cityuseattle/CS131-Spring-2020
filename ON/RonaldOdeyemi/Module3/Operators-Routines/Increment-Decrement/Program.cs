using System;

namespace Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a <= 10; a++)
            {
                Console.WriteLine(a);

                /* I've created a For Loop argument within the Main Function. Within the For Loop, I have created an integer called "a" with an assigned value of 0. 
                The argument looks at the boolean statement of a is less than or equal to 10. Everytime this statement is true, the value of "a" is displayed through the
                Console.WriteLine(a) command and then the For Loop increments "a" by 1 using the post increment operator. The process repeats itself through this loop, each time
                displaying the value of "a" on a new line through the "WriteLine" command ("Write" would have displayed each value next to each other). The For Loop terminates
                when the statement of "a is less than or equal to 10" is false i.e. the final value displayed is 10 */
                
            }

            for (int a = 15; a >= 1; a--)

            {
                Console.WriteLine(a);
            }
        }
    }
}
