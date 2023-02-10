using System;
using Xunit;
using Lab4_3_PrimeNum;

namespace Lab4_3_PrimeNum_Test
{
    public class UnitTest1
    {
        // Even number test (only 2 should be a prime number (true)
        [Theory]
        [InlineData(0, false)]
        [InlineData(2, true)]
        [InlineData(4, false)]
        [InlineData(6, false)]
        [InlineData(8, false)]
        [InlineData(10, false)]
        [InlineData(14, false)]
        [InlineData(20, false)]
        [InlineData(30, false)]
        [InlineData(40, false)]
        [InlineData(50, false)]
        [InlineData(125, false)]
        [InlineData(140, false)]
        [InlineData(300, false)]

        // All MULTIPLES of 3 and 7 (except 3 & 7 individually) are not prime (== false), any number > 5 ending in "5" is NOT a prime number

        [InlineData(1, false)]
        [InlineData(3, true)]
        [InlineData(5, true)]
        [InlineData(7, true)]
        [InlineData(9, false)]
        [InlineData(13, true)]
        [InlineData(15, false)]
        [InlineData(17, true)]
        [InlineData(19, true)]
        [InlineData(21, false)]
        [InlineData(25, false)]
        [InlineData(29, true)]
        [InlineData(31, true)]
        [InlineData(77, false)]

        [InlineData(349, true)]
        [InlineData(379, true)]
        [InlineData(467, true)]
        [InlineData(541, true)]
        [InlineData(617, true)]

        public void TestIsPrime(int n, bool expected)
        {
            bool actual = PrimeNumbers.IsPrime(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(9, 23)]
        [InlineData(10, 29)]
        [InlineData(13, 41)]
        [InlineData(19, 67)]
        [InlineData(29, 109)] // Tests good up to this point as expected

        [InlineData(69, 347)] // Returns 283
        [InlineData(70, 349)]
        [InlineData(75, 379)]
        [InlineData(91, 467)]
        [InlineData(100, 541)]
        [InlineData(113, 617)]

        public void TestNthPrime(int num, int expected)
        {
            int actual = PrimeNumbers.GetPrime(num);
            Assert.Equal(expected, actual);
        }
    }
}
