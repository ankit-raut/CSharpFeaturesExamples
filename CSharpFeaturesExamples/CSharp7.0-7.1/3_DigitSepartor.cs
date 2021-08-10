using System;

namespace CSharpFeaturesExamples.CSharp7._0_7._1
{
    public class DigitSepartor
    {
        public static void Run()
        {
            // Both are equivalent.
            var bigNumber = 123456789012345678;
            var bigNumberSplit = 123_456_789_012_345_678;
            Console.WriteLine("bigNumber : {0}, bigNumberSplit : {1}", bigNumber, bigNumberSplit);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
