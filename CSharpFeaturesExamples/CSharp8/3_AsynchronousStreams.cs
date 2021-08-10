using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeaturesExamples.CSharp8
{
    public static class AsynchronousStreams
    {
        public static void Run()
        {
            _ = GenerateSequence();
        }

        private static async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
    }
}
