using System;
using System.Security.Cryptography;

namespace MethodCalls
{
    class MethodCallsProgram
    {
        public static float CalculateAverage(float num1, float num2, float num3)
        {
            float average = (num1 + num2 + num3) / 3;
            return average;
        }

        public static void ShowAverage(String studentName, float average)
        {
            Console.WriteLine(studentName + " average: " + average);
        }

        static void Main(string[] args)
        {
            const float MATH_GRADE = 80.0f;
            const float BIOLOGY_GRADE = 80.0f;
            const float PROGRAMMING_GRADE = 92.0f;
            const string STUDENT_NAME = "G. Treela";
            //Call CalculateAverage() to calculate the average grade.
            float average = CalculateAverage(MATH_GRADE, BIOLOGY_GRADE, PROGRAMMING_GRADE);
            //Call ShowAverage() to dispay the student name and overall average.
            ShowAverage(STUDENT_NAME, average);
            Console.ReadLine();
        }
    }
}
