using CSharpFeaturesExamples.CSharp7._0_7._1;
using CSharpFeaturesExamples.CSharp7._2_7._3;
using CSharpFeaturesExamples.CSharp8;

namespace CSharpFeaturesExamples
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            // CSharp 7.x
            OutParameters_Discard.Run();
            PatternMatching.Run();
            DigitSepartor.Run();
            TuplesBefore7.Run();
            TuplesAfter7.Run();
            TuplesSplitting.Run();

            NonTrailingNamedArguments.Run();

            //CSharp 8
            NullableRefType.Run();
            PatternMatching_8.Run();
            AsynchronousStreams.Run();
            UsingDeclartion.Run();
            NullCoalescing.Run();
            IndicesRanges.Run();
        }
    }
}
