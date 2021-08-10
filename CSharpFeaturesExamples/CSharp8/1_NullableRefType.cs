using System;

namespace CSharpFeaturesExamples.CSharp8
{
    public class NullableRefType
    {
        public static void Run()
        {
            string? nullableString = null;
            Console.WriteLine(nullableString.Length);   // WARNING: may be null! Take care! 
        }
    }
}
