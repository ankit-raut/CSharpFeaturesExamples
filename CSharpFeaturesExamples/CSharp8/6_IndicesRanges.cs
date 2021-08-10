using System;

namespace CSharpFeaturesExamples.CSharp8
{
    public static class IndicesRanges
    {
        public static void Run()
        {
            var words = new string[]
                {
                                // index from start    index from end
                    "The",      // 0                   ^9
                    "quick",    // 1                   ^8
                    "brown",    // 2                   ^7
                    "fox",      // 3                   ^6
                    "jumped",   // 4                   ^5
                    "over",     // 5                   ^4
                    "the",      // 6                   ^3
                    "lazy",     // 7                   ^2
                    "dog"       // 8                   ^1
                };              // 9 (or words.Length) ^0

            Console.WriteLine($"The last word is {words[^1]}");// writes "dog"
            var quickBrownFox = words[1..4];    // contains "quick", "brown", and "fox"
            var lazyDog = words[^2..^0];        // contains "lazy" and "dog"
            var allWords = words[..];           // contains "The" through "dog".
            var firstPhrase = words[..4];       // contains "The" through "fox"
            var lastPhrase = words[6..];        // contains "the", "lazy" and "dog"
            Range phrase = 1..4;                // assinging range in variable
            var text = words[phrase];           // contains "quick", "brown", and "fox"
        }
    }
}
