using System;
using System.Collections.Generic;

namespace UnitTestingAssessment_After
{
    public class Methods
    {
        public static string RockPaperScissors(string player1, string player2)
        {
            if (player1 == player2)
            {
                return "It's a tie!";
            }
            else if ((player1 == "rock" && player2 == "scissors") ||
                     (player1 == "scissors" && player2 == "paper") ||
                     (player1 == "paper" && player2 == "rock"))
            {
                return "Player 1 wins!";
            }
            else
            {
                return "Player 2 wins!";
            }
        }

        public static void SortNums(List<int> numbers)
        {
            numbers.Sort();

        }

        public static bool IsTheSunUp(TimeSpan tod)
        {
            return (tod.Hours > 7) && (tod.Hours < 20);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Just another bad test day!!!");
        }
    }

}
