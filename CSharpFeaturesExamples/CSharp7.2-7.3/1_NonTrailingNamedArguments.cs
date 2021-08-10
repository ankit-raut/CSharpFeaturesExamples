namespace CSharpFeaturesExamples.CSharp7._2_7._3
{
    public class NonTrailingNamedArguments
    {
        public static void Run()
        {
            // method call
            WriteText("Hello world", centered: true);
            WriteText("Hello world", true, true); // difficult to understand
            WriteText("Hello world", bold: true, centered: true); // better
            WriteText("Hello world", centered: true, bold: true); // different order

            WriteText("Hello world", bold: true, true); // not allowed before C# 7.2
        }
        static void WriteText(string text, bool bold = false, bool centered = false)
        {
            // method implementation
        }
    }
}
