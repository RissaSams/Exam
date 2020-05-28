using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Converting
    {
        static void Main(string[] args)
        {
            int goAgain = Utils.GetNumber("To quit put '0', to convert put any number: ");
            do
            {
                Convert();
                goAgain = Utils.GetNumber("To quit put '0', to convert put any number: ");
            } while (goAgain != 0);
        }

        private static void Convert()
        {
            string convertTo;
            float distance;
            distance = Utils.GetFloat("How far is the distance? ");
            convertTo = Utils.GetInput("What would you like to convert to? ");
                        
            if (convertTo.Equals("ft"))
            {
                Console.WriteLine($"{distance} mile is {distance * 5280} feet!");
            }
            else if (convertTo.Equals("in"))
            {
                Console.WriteLine($"{distance} mile is {distance * 63360} inches!");
            }
            else if (convertTo.Equals("yards"))
            {
                Console.WriteLine($"{distance} mile is {distance * 1760} yards!");
            }
            else if (convertTo.Equals("km"))
            {
                Console.WriteLine($"{distance} mile is {distance * 1.609} kilometers!");
            }

            
                       
        }
    }
}
