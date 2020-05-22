using System;

namespace Birthday
{
    class BirthdayClass
    {
        static void Main(string[] args)
        {
            const int YEAR = 1990, MONTH = 01, DAY = 30, HRS = 12, MIN = 20, SEC = 40; //Constants for birthdate.
            DateTime birthDay = new DateTime(YEAR, MONTH, DAY, HRS, MIN, SEC); //create DateTime.
            showBirthDay(birthDay);
            Console.WriteLine("Birthday in long date format: {0}", birthDay.ToLongDateString()); //Displays date time in long date format.
        }

        static void showBirthDay(DateTime birthDay)
        {
            Console.WriteLine("Year : {0}, Month: {1}, Day: {2}", birthDay.Year, birthDay.Month, birthDay.Day); //Displays year, month and day.
            Console.WriteLine("DayOfTheWeek : {0}, DayofTheYear: {1}", birthDay.DayOfWeek, birthDay.DayOfYear); //Displays day of the week and year.
            Console.WriteLine("BirthTimeHr : {0}, BirthTimeMin: {1}", birthDay.Hour, birthDay.Minute); //displays hour and minute of DateTime.
        }
    }
}
