using System.IO;

using static System.Console;

namespace CSharpFeaturesExamples.CSharp8
{
    public static class UsingDeclartion
    {
        public static void Run()
        {
            // C# Oldy Style  
            using (var stringReaderOld = new StringReader("Testing"))
            {
            } // repository is disposed here!    

            // vs.C# 8    
            using var stringReaderNew = new StringReader("Testing");
            WriteLine(stringReaderNew.ToString());
            // repository is disposed here!  
        }
    }
}
