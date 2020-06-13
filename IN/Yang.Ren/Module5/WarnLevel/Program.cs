using System;

namespace WarnLevel
{
    class Program
    {
        const int INACTIVE = -1;
        const int F0 = 0, F1 = 1, F2 = 2, F3 = 3;
        static void Main()
        {
            int strength = INACTIVE;
            ShowWarning(strength);
            strength = F3;
            ShowWarning(strength);
            Console.ReadLine();

            const bool Show_Warning = true;
            int strength = F3;
            Report(strength, Show_Warning);

            int strength = F2;
            Report(strength, Show_Warning);

            int strength = F1;
            Report(strength, Show_Warning);

            int strength = F0;
            Report(strength, Show_Warning);

        }
        public static void ShowWarning(int strength)
        {
            if(strength == F3)
            {
                Console.WriteLine("F3+: Severe damage warning.");
            }
            else if(strength == F2)
            {
                Console.WriteLine("F2: Significant damage warning,");
            }
            else if(strength == F1)
            {
                Console.WriteLine("F1: Moderate damage warning.");
            }
            else
            {
                Console.WriteLine("Inactive: No damage.");
            }
            static  void Report(int strength, bool Show_Warning);
            {
                Console.WriteLine("Warnlevel: " + strength);

                if (strength > 0 && strength <= 2)
                    Console.WriteLine("Moderate Damage.");
                else if (strength >= 3 || !ShowWarning)
                    Console.WriteLine("Warning!!!!");
            }
        }

    }
}
