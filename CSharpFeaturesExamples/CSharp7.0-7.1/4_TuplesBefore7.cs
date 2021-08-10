using System;
using System.Collections.Generic;

namespace CSharpFeaturesExamples.CSharp7._0_7._1
{
    public class TuplesBefore7
    {
        public static void Run()
        {
            var values = new List<double>() { 10, 20, 30, 40, 50 };
            Tuple<int, double> t = Calulate(values);
            Console.WriteLine($"There are {t.Item1} values and their sum is {t.Item2}");
            Console.ReadKey();
        }
        //Declaring the return type as Tuple<int, double>
        private static Tuple<int, double> Calulate(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            foreach (var value in values)
            {
                count++;
                sum += value;
            }
            //Creating an object of Tuple class by calling the static Create method
            Tuple<int, double> t = Tuple.Create(count, sum);
            //Returning the tuple instance
            return t;
        }
    }
}
