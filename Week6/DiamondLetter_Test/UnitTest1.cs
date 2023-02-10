using System;
using Xunit;
using DiamondLetter;

namespace DiamondLetter_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("A", 0)]
        [InlineData("B", 1)]
        [InlineData("C", 2)]
        [InlineData("Z", 25)]
        public void TestLetterIndex(string Letter, int expected)
        {
            int actual = Diamond.LetterIndex(Letter);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(3, 5)]
        [InlineData(5, 9)]
        [InlineData(7, 13)]

        public void TestCalculateDots(int LetterIndex, int expected)
        {
            int actual = Diamond.CalculateDots(LetterIndex);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("A","A","A")]
        [InlineData("B","A", ".A.")]
        [InlineData("B","B", "B.B")]
        [InlineData("C","B", ".B.B.")]
        [InlineData("C","C", "C...C")]
        [InlineData("D","A", "...A...")]
        [InlineData("D","B", "..B.B..")]
        [InlineData("D","D", "D.....D")]

        public void TestDrawLine(string BlockLetter, string Current, string expected)
        {
            string actual = Diamond.DrawLine(BlockLetter, Current);
            Assert.Equal(expected, actual);
        }

    }
}
