using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = BePrepared();
            clothes.ForEach(Console.WriteLine);
        }

        private static List<string> BePrepared()
        {
            List<string> clothing = new List<string>();
            int temp = GetNumber("What is the temp for the day? ");
            double wind = GetDouble("How fast is the wind today? ");
            double rain = GetDouble("What is the rain percentage for the day? ");
            string forecast = GetInput("What is the forecast going to be? ");

            if (temp <= 32)
            {
                clothing.Add("Put on a heavy coat");
            }
            else if (temp > 32 && temp <= 40)
            {
                clothing.Add("Wear your mittens");
            }
            else if (temp > 40 && temp <= 70)
            {
                clothing.Add("Dig out your long sleeve shirt");
            }
            else if (temp > 70)
            {
                clothing.Add("A short sleeve shirt will be fine");
            }
            else if (temp > 110)
            {
                clothing.Add("Move out of Texas");
            }

            if (wind < 10.8)
            {
                clothing.Add("Nothing extra");
            }
            else if (wind >= 10.8 && wind < 45.5)
            {
                clothing.Add("Put on a wind breaker");
            }
            else if (wind >= 45.5 && wind < 75.2)
            {
                clothing.Add("Stay in doors");
            }
            else if (wind >= 75.2)
            {
                clothing.Add("Get to the storm cellar");
            }

            if (rain <= .1)
            {
                clothing.Add("Don't worry about it");
            }
            else if (rain > .1 && rain <= .35)
            {
                clothing.Add("Wear a hat");
            }
            else if (rain > .35)
            {
                clothing.Add("Take an umbrella");
            }
            else if (rain > .80)
            {
                clothing.Add("Stay at home and reas a book");
            }

            switch (forecast)
            {
                case "sunny":
                    clothing.Add("Put on you sunglasses and sunscreen");
                    break;
                case "windy":
                    clothing.Add("Wear a coat");
                    break;
                case "snowy":
                    clothing.Add("Wear your boots");
                    break;
                default:
                    break;
            }
            return clothing;
        }

        public static int GetNumber(string prompt)
        {
            int userNumber;
            string strNumber = GetInput(prompt);
            while (!Int32.TryParse(strNumber, out userNumber))
            {
                Console.WriteLine("That is not an integer");
                strNumber = GetInput(prompt);
            }

            return userNumber;
        }

        public static double GetDouble(string prompt)
        {
            double userNumber;
            string strNumber = GetInput(prompt);
            while (!Double.TryParse(strNumber, out userNumber))
            {
                Console.WriteLine("That is not an integer");
                strNumber = GetInput(prompt);
            }

            return userNumber;
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }
    }
}
