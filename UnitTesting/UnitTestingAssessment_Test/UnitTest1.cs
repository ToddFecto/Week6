using System;
using Xunit;
using UnitTestingAssessment;
using System.Globalization;
using System.Collections.Generic;

namespace UnitTestingAssessment_Test
{
    public class UnitTest1
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


        //Tests for sort order of 5 integers
        //[Theory]
        //[InlineData(new int[] { }, 0)]
        //[InlineData(new int[] { 1, 2, 3, 4, 5 },  {1, 2, 3, 4, 5})]
        //[InlineData(new int[] { 5, 4, 3, 2, 1 },  {1, 2, 3, 4, 5})]
        //[InlineData(new int[] { 1, 3, 2, 4, 5 },  {1, 2, 3, 4, 5})]
        //[InlineData(new int[] { 5, 2, 3, 4, 1 },  {1, 2, 3, 4, 5})]

        //public void TestSortNumUp(int[] numUp, int[] expected)
        //{
        //    Methods.SortNums.List<int> nums = new List<int>(numUp);
        //    Methods sortUp = new Methods();
        //    int actual = sortUp.SortNums(nums);
        //    Assert.Equal(expected, actual);
        //}



        //Tests the TOD is between 7 (7am) and 20 (8pm)
        //Tests true for >= 8am and <= 20 (8pm) and false 
        //[Theory]
        //[InlineData(TimeSpan interval new TimeSpan(07, 15, 00), false)]
        //[InlineData(TimeSpan interval new TimeSpan[](08, 15, 00), true)]
        //[InlineData(TimeSpan interval new TimeSpan[](09, 15, 00), true)]
        //[InlineData(TimeSpan interval new TimeSpan[](17, 15, 00), true)]
        //[InlineData(TimeSpan interval new TimeSpan[](20, 15, 00), false)]


        //public void TestIsSunUp(TimeSpan tod, bool expected)
        //    {
        //        bool result = Methods.IsTheSunUp(tod);
        //        Assert.Equal(expected, result);
        //    }
    }
}
