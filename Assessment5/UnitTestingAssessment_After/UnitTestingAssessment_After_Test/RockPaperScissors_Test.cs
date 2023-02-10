using System;
using Xunit;
using UnitTestingAssessment_After;
using System.Globalization;
using System.Collections.Generic;

namespace UnitTestingAssessment_After_Test
{
    public class TimeOfDay_Test
    {
        //Tests the TOD is between 7 (7am) and 20 (8pm)
        //Tests true for >= 8am and <= 20 (8pm) and false for anytime before or after those times
        [Theory]
        [InlineData(07, 15, 00, false)]
        [InlineData(08, 15, 00, true)]
        [InlineData(09, 15, 00, true)]
        [InlineData(17, 15, 00, true)]
        [InlineData(20, 15, 00, false)]


        public void TestIsSunUp(int hours, int minutes, int seconds, bool expected)
        {
            TimeSpan tod = new TimeSpan(hours, minutes, seconds);
            bool actual = Methods.IsTheSunUp(tod);

            Assert.Equal(expected, actual);
        }
    }
    public class SortNums_Test
    {
        //Tests for sort order of 5 integers
        [Theory]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5})]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5})]
        [InlineData(new int[] { 1, 3, 2, 4, 5 }, new int[] { 1, 2, 3, 4, 5})]
        [InlineData(new int[] { 5, 2, 3, 4, 1 }, new int[] { 1, 2, 3, 4, 5})]

        public void TestSortNumUp(int[] numUp, int[] expected)
        {// The actual List you will call the method on 

            List<int> actual = new List<int>(numUp);

            // Call the method - it's void and doesn't return anything 
            // It just sorts numbers passed to it 

            Methods.SortNums(actual);
            // The expected list after the sort 

            List<int> expectedList = new List<int>(expected);

            // Assert 
            Assert.Equal(actual, expectedList);
        }
        }
    public class RockPaperScissors_Test
    {
        //This tests for the condition that Player1 and Player2 BOTH choose the SAME item (i.e. rock and rock)
        [Theory]
        [InlineData("rock", "rock", "It's a tie!")]
        [InlineData("paper", "paper", "It's a tie!")]
        [InlineData("scissors", "scissors", "It's a tie!")]
        public void TestP1EqualP2(string player1, string player2, string expected)
        {
            string actual = Methods.RockPaperScissors(player1, player2);
            Assert.Equal(expected, actual);
        }

        //Tests for the three conditions that Player1 chooses that BEATS Player2 (i.e. P1 = rock beats P2 = scissors)
        [Theory]
        [InlineData("rock", "scissors", "Player 1 wins!")]
        [InlineData("scissors", "paper", "Player 1 wins!")]
        [InlineData("paper", "rock", "Player 1 wins!")]
        public void TestP1Wins(string player1, string player2, string expected)
        {
            string actual = Methods.RockPaperScissors(player1, player2);
            Assert.Equal(expected, actual);
        }

        //Tests for the three conditions that Player2 chooses that BEATS Player1 (i.e. P2 = rock beats P1 = scissors)
        [Theory]
        [InlineData("scissors", "rock", "Player 2 wins!")]
        [InlineData("paper", "scissors", "Player 2 wins!")]
        [InlineData("rock", "paper", "Player 2 wins!")]
        public void TestP2Wins(string player1, string player2, string expected)
        {
            string actual = Methods.RockPaperScissors(player1, player2);
            Assert.Equal(expected, actual);
        }
    }
}
