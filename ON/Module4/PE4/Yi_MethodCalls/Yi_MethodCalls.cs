using System;

namespace Yi_MethodCalls
{
    class Program
    {
        /**The CalculateAverage method takes the three grades the G.Treele
        obtained and calculates the average grade between the three **/
        static float CalculateAverage(float grd1, float grd2, float grd3)
        {
            float average = (grd1 + grd2 + grd3) / 3;
            return average;
        }

        /**The ShowAverage method takes G.Treele's name and the average
          score and writes the added information**/
        static void ShowAverage(string studname, float avegrd)
        {
            Console.WriteLine(studname + ": " + avegrd );
        }
        
        static void Main()
        {
            const float MATH_GRADE = 80.0f;
            const float BIOLOGY_GRADE = 80.0f;
            const float PROGRAMMING_GRADE = 92.0f;
            const string STUDENT_NAME = "G.Treele";
            
            //Call the CalculateAverage method 
            float average = CalculateAverage(MATH_GRADE, BIOLOGY_GRADE, PROGRAMMING_GRADE);
            
            //Calls the ShowAverage method
            ShowAverage(STUDENT_NAME, average);
            Console.ReadLine();
        }
    }
}