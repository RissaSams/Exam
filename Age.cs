using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Age
    {
        static void Main(string[] args)
        {
            var ageSeconds = AgeToSeconds();
            Console.WriteLine($"You are {ageSeconds} seconds old!");
        }

        private static double AgeToSeconds()
        {
            int birthYear, birthMonth, birthDay;            
            birthMonth = Utils.GetNumber("What month were you born? ");
            birthDay = Utils.GetNumber("What day were you born? ");
            birthYear = Utils.GetNumber("What year were you born? ");
            DateTime years = new DateTime(birthYear, birthMonth, birthDay);
            DateTime today = DateTime.Today;
            TimeSpan age = years.Subtract(today);
            double seconds = age.TotalSeconds;

            return seconds;
        }
    }
}
