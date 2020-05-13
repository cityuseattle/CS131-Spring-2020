using System;

namespace MethodCalls
{
    class Program
    {
        public static void Main()
        {
            const float MATH_GRADE = 80.0f;
            const float BIOLOGY_GRADE = 80.0f;
            const float PROGRAMMING_GRADE = 92.0F;
            const string STUDENT_NAME = "G. Treele";
            // Call CalculateAverage () to Calc the avg grade

            float average = CalculateAverage(MATH_GRADE, BIOLOGY_GRADE, PROGRAMMING_GRADE);

            // Call ShowAverage() to display the students name and overall grade average
            ShowAverage(STUDENT_NAME, average);
            Console.WriteLine(average);
            Console.WriteLine(STUDENT_NAME, average);

            Console.ReadLine();
        }

        public static void ShowAverage(string STUDENT_NAME, float average)
        {

        }

        public static float CalculateAverage(float MATH_GRADE, float BIOLOGY_GRADE, float PROGRAMMING_GRADE)
        {

        }
    }
}
