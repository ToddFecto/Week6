using System;
using System.Collections.Generic;

namespace TrianglePrint
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDiamond('M');
        }
        static void PrintDiamond(char c)
        {
            int alphabetIndex = c - 64;
            int lineCharCount = alphabetIndex * 2 - 1;
            string line = new string('*', lineCharCount);
            int center = (lineCharCount - 1) / 2;
            List<string> upperHalfDiamond = new List<string>();
            for (int row = 1; row <= alphabetIndex; row++)
            {
                char letter = GetAlphabetLetter(row);
                char[] lineAsArray = line.ToCharArray();

                int position1 = center - row + 1;
                int position2 = center + row - 1;
                lineAsArray[position1] = letter;
                lineAsArray[position2] = letter;
                string newLine = new string(lineAsArray);

                Console.WriteLine(newLine);
                upperHalfDiamond.Add(newLine);
            }
            upperHalfDiamond.Reverse();
            for (int i = 1; i < upperHalfDiamond.Count; i++)
            {
                Console.WriteLine(upperHalfDiamond[i]);
            }
        }
        private static char GetAlphabetLetter(int n)
        {
            return char.ConvertFromUtf32(n + 64)[0];
        }
    }
}