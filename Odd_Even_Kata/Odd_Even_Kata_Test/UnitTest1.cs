using System;
using Xunit;
using Odd_Even_Kata;

namespace Odd_Even_Kata_Test
{
    public class UnitTest1
    {
        //Testing for EVEN Numbers AND 0 AND 1
        [Theory]
        [InlineData(0, false)]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(4, true)]
        [InlineData(5, false)]
        [InlineData(8, true)]
        [InlineData(10, true)]
        [InlineData(13, false)]
        [InlineData(20, true)]
        [InlineData(25, false)]

        public void TestEven(int n, bool expected)
        {
            bool actual = OddEvenPrime.IsEven(n);
            Assert.Equal(expected, actual);
        }

        //Testing for ODD Numbers AND 0
        [Theory]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(2, false)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(8, false)]
        [InlineData(10, false)]
        [InlineData(13, true)]
        [InlineData(20, false)]
        [InlineData(25, true)]

        public void TestOdd(int n, bool expected)
        {
            bool actual = OddEvenPrime.IsOdd(n);
            Assert.Equal(expected, actual);
        }

        //Testing for PRIME Numbers
        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
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
        [InlineData(97, true)]
        [InlineData(100, false)]

        public void TestIsPrime(int n, bool expected)
        {
            bool actual = OddEvenPrime.IsPrime(n);
            Assert.Equal(expected, actual);
        }
    }
}
