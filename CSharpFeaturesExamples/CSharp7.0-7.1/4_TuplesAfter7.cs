using System;
using System.Collections.Generic;

namespace CSharpFeaturesExamples.CSharp7._0_7._1
{
    public class TuplesAfter7
    {
        public static void Run()
        {
            var values = new List<double>() { 10, 20, 30, 40, 50 };
            var result = Calulate(values);
            Console.WriteLine($"There are {result.Item1} values and their sum is {result.Item2}");
            Console.ReadKey();
        }

        private static (int, double) Calulate(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            foreach (var value in values)
            {
                count++;
                sum += value;
            }
            return (count, sum);
        }
    }
}
