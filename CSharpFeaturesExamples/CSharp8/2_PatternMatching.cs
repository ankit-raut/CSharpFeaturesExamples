using System;

namespace CSharpFeaturesExamples.CSharp8
{
    public class Address {
        public string State { get; set; }
    }
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) =>
            (x, y) = (X, Y);
    }

    public static class PatternMatching_8
    {
        #region Declaration
        public enum Rainbow
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Indigo,
            Violet
        }
        public enum Quadrant
        {
            Unknown,
            Origin,
            One,
            Two,
            Three,
            Four,
            OnBorder
        }
        #endregion

        public static void Run()
        {
            FromRainbow(Rainbow.Yellow);
            ComputeSalesTax(new Address { State = "WA" }, 0.06M);
            RockPaperScissors("rock", "paper");
        }

        //Switch Expression
        public static string FromRainbow(Rainbow colorBand) =>
            colorBand switch
            {
                Rainbow.Red => Rainbow.Red.ToString(),
                Rainbow.Orange => Rainbow.Orange.ToString(),
                Rainbow.Yellow => Rainbow.Yellow.ToString(),
                Rainbow.Green => Rainbow.Green.ToString(),
                Rainbow.Blue => Rainbow.Blue.ToString(),
                Rainbow.Indigo => Rainbow.Indigo.ToString(),
                Rainbow.Violet => Rainbow.Violet.ToString(),
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
            };

        //Property patterns
        public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
            location switch
            {
                { State: "WA" } => salePrice * 0.06M,
                { State: "MN" } => salePrice * 0.075M,
                { State: "MI" } => salePrice * 0.05M,
                // other cases removed for brevity...
                _ => 0M
            };

        //Tuple patterns
        public static string RockPaperScissors(string first, string second) => (first, second) 
            switch
            {
                ("rock", "paper") => "rock is covered by paper. Paper wins.",
                ("rock", "scissors") => "rock breaks scissors. Rock wins.",
                ("paper", "rock") => "paper covers rock. Paper wins.",
                ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
                ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
                ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
                (_, _) => "tie"
            };

        //Positional patterns
        static Quadrant GetQuadrant(Point point) => point switch
        {
            (0, 0) => Quadrant.Origin,
            var (x, y) when x > 0 && y > 0 => Quadrant.One,
            var (x, y) when x < 0 && y > 0 => Quadrant.Two,
            var (x, y) when x < 0 && y < 0 => Quadrant.Three,
            var (x, y) when x > 0 && y < 0 => Quadrant.Four,
            var (_, _) => Quadrant.OnBorder,
            _ => Quadrant.Unknown
        };
    }
}
