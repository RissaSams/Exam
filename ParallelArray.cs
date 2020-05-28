using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
    class ParallelArray
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 0, 1, 3, 77, 137, 343, 7, 13, 21, 37, 73 };
            string[] flavors = { "lemon", "lime", "vanilla", "rocky road", "chocolate", "butter pecan" };

            int max = luckyNumbers.Max();
            Console.WriteLine($"The biggest number is {max}!");
            var above100 = luckyNumbers.Where(n => n > 100).ToArray();
            Console.WriteLine($"The numbers above 100 are {above100}!");
            var ave = luckyNumbers.Average();
            Console.WriteLine($"The average is {ave}.");
            var order = luckyNumbers.OrderBy(n => n);

            var wordsWithL = flavors.Contains("l");
            var beginWithL = flavors.Where(f => f.StartsWith("l"));
            var orderBy = flavors.OrderBy(f => f.Length);
            var mocoa = flavors.Any(f => f.Contains("mocoa"));
        }
    }
}
