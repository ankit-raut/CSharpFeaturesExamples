using System;
using System.Collections.Generic;

namespace CSharpFeaturesExamples.CSharp8
{
    public static class NullCoalescing
    {
        public static void Run()
        {
            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);

            Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
            Console.WriteLine(i);  // output: 17
        }
    }
}
