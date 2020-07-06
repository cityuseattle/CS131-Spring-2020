using System;

namespace MethodCalls
{
    class Program
    {
        public static float CalculateAverage(float a, float b, float c)
        {
            float sum = a + b + c;
            float average = sum / 3;
            return average;
        }
        public static string Str2;
        static void ShowAverage(string Str1, float num1)
        {
            Str2 = " average: ";
        
            Console.Write(Str1);
          

        }
        static void Main()
        {
            const float MATH_GRADE = 80.0f;
            const float BIOLOGY_GRADE = 80.0f;
            const float PROGRAMMING_GRADE = 92.0f;
            const string STUDENT_NAME = "G.Treele";

           
            float average = CalculateAverage(MATH_GRADE, BIOLOGY_GRADE, PROGRAMMING_GRADE);
           
            ShowAverage(STUDENT_NAME,average);
            //Console.Write(CalculateAverage(MATH_GRADE, BIOLOGY_GRADE, PROGRAMMING_GRADE));
            Console.WriteLine(Str2);
            Console.ReadLine();
        }
    }
}
