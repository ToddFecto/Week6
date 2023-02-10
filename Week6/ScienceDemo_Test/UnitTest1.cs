using System;
using Xunit;
using ScienceDemo;

namespace ScienceDemo_Test
{
    public class UnitTest1
    {
        /*
         *  Tests
         *  D       R       Expected
         * 100.0    2.0     50.0
         * 80.0     40.0    2.0
         * 20.0     4.0     5.0
         * We want to do all three of these tests
         * with this one funciton
         */
        [Theory]  
        [InlineData(100.0, 2.0, 50.0)]
        [InlineData(80.0, 40.0, 2.0)]
        [InlineData(20.0, 4.0, 5.0)]
        public void TestTouchdownTime(double dist, double rate, double expected)
        {
            //double time = Program.TimeUntilTouchdown(dist, rate);
            //Assert.Equal(expected, time);
            Assert.Equal(expected, Program.TimeUntilTouchdown(dist, rate)); // Combining the two lines of code
        }

        /*
         * Tests
         * N        Expected
         * 0        true
         * 1        true
         * 4        false
         * 8        true
         * 10       false
         * 21       true
         * 25       false
         */
        [Theory]
        [InlineData(0, true)]
        [InlineData(1, true)]
        [InlineData(4, false)]
        [InlineData(8, true)]
        [InlineData(10, false)]
        [InlineData(21, true)]
        [InlineData(25, false)]
        [InlineData(144, true)]

        public void TestIsFib(int num, bool expected)
        {
            bool result = Program.IsFibonacci(num);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 1)]
        [InlineData(6, 5)]
        [InlineData(9, 21)]
        [InlineData(10, 34)]
        [InlineData(13, 144)]

        public void TestNthFib(int num, int expected)
        {
            int actual = Program.GetNthFib(num);
            Assert.Equal(expected, actual);
        }


    }
}
