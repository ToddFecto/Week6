using System;

namespace DiamondLetter
{
    public class Diamond
    {
        public static int LetterIndex(string Letter)
        {
            // Example: A => 0 index place
            return (int)(Letter[0]) - 65; // Cast the "letter" input to a number then use the ASCII location minus 65,
                                            // ASCII values start at "A" == 66.
        }

        public static int CalculateDots(int LetterIndex)
        {
            if (LetterIndex == 0)
            {
                return 0;
            }
            return 2 * LetterIndex - 1;
        }

        public static string DrawLine(string Letter, string current)
        {
            // Example:
            // Letter is D, and current is D
            //  "D.....D"
            // Letter is D, and current is B
            //  "..B.B.."
            if (Letter == "A" && current == "A")
            {
                return "A";
            }
            // Calculate dots in the middle
            int total = CalculateDots(LetterIndex(Letter));
            int middle = CalculateDots(LetterIndex(current));
            // Calculate dots to the left and right
            int padding = (total - middle) / 2;
            if (current == "A")
            {
                padding++;
                string result = new string('.', padding) +
                    "A" +
                    new string('.', padding);
                return result;
            }
            else
            {
                string result = new string('.', padding) +
                    current +
                    new string('.', middle) +
                    current +
                    new string('.', padding);
                return result;
            }
        }

        public static void DrawDiamond(string Letter)
        {
            string line = "";
            char nextLetter;
            int index = LetterIndex(Letter);
            for (int i = 0; i <= index; i++)
            {
                nextLetter = (char)(i + 65);  // (1 + 65) created an arrow effect and not a diamond
                line = DrawLine(Letter, nextLetter.ToString());
                Console.WriteLine(line);
            }
            for (int i = index - 1; i >= 0; i--)
            {
                nextLetter = (char)(i + 65);
                line = DrawLine(Letter, nextLetter.ToString());
                Console.WriteLine(line);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Diamond.DrawDiamond("d");  // Enter the character that it will build up to and then down from for diamond shape.
        }
    }
}
