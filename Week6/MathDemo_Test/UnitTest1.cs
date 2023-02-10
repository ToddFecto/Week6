using System;
using Xunit;
using MathDemo;

namespace MathDemo_Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd1()
        {
            int num = Program.Add(5, 3);
            Assert.Equal(8, num);
        }

        [Fact]
        public void TestBigFormula()
        {
            int num = Program.BigFormula(5, 3, 2);
            Assert.Equal(6, num);
        }

        [Fact]
        public void TestCouponNoCoupon()
        {
            bool coupon = Program.IsCoupon(5.00m);
            Assert.False(coupon);
        }

        [Fact]
        public void TestCouponYesCoupon()
        {
            bool coupon = Program.IsCoupon(15.00m);
            Assert.True(coupon);
        }

        [Fact]
        public void TestCouponCouponTen()
        {
            bool coupon = Program.IsCoupon(10.00m);
            Assert.True(coupon);
        }

        [Fact]
        public void TestMultiply()
        {
            int num = Program.Multiply(5, 3); // Delete this line if using commented line below
            Assert.Equal(15, num); // or Assert.Equal(15, Program.Multiply(5, 3));
        }
    }
}
