using System;

namespace warnLevel1
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
            int Warning = 3;
            Report(Warning, Show_Warning);

            int Warning = 2;
            Report(Warning, Show_Warning);

            int Warning = 1;
            Report(Warnng, Show_Warning);

            int Warning = 0;
            Report(Warning, Show_Warning);

        }
        public static void ShowWarning(int strength)
        {
            if (strength == F3)
            {
                Console.WriteLine("F3+: Severe damage warning.");
            }
            else if (strength == F2)
            {
                Console.WriteLine("F2: Significant damage warning,");
            }
            else if (strength == F1)
            {
                Console.WriteLine("F1: Moderate damage warning.");
            }
            else
            {
                Console.WriteLine("Inactive: No damage.");
            }
            static void Report(int Warning, bool ShowWarning);
            {
                Console.WriteLine("Warnlevel: " + Warning);

                if ( Warning >=0 && Warning <= 1)
                    Console.WriteLine("Moderate Damage.");
                else if (Warning > 2 || Warning == 3)
                    Console.WriteLine("Warning!!!!");
            }
        }

    }
}