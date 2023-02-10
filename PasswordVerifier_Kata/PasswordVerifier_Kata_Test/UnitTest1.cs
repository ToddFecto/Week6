using System;
using Xunit;
using PasswordVerifier_Kata;

namespace PasswordVerifier_Kata_Test
{
    public class UnitTest1
    {
        //Testing that password is > 8 chars in length
        [Theory]
        [InlineData("TestPass", false)]
        [InlineData("TestPss", false)]
        [InlineData("TestPass8", true)]

        public void TestPassLength(string v, bool expected)
        {
            bool actual = PasswordVerifier.Is8Chars(v);
            Assert.Equal(expected, actual);
        }

        //Testing that password isn't NULL chars in length
        [Theory]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("TestPass8", true)]

        public void TestNullLength(string v, bool expected)
        {
            bool actual = PasswordVerifier.IsPassNull(v);
            Assert.Equal(expected, actual);
        }

        //Testing that password contains at least One UPPERCase letter
        [Theory]
        [InlineData("testpass8", false)]
        [InlineData("Testpass8", true)]

        public void TestPassUpper(string v, bool expected)
        {
            bool actual = PasswordVerifier.IsUpperCase(v);
            Assert.Equal(expected, actual);
        }

        //Testing that password contains at least One LowerCase letter
        [Theory]
        [InlineData("TESTPASS8", false)]
        [InlineData("tESTPASS8", true)]

        public void TestPassLower(string v, bool expected)
        {
            bool actual = PasswordVerifier.IsLowerCase(v);
            Assert.Equal(expected, actual);
        }

        //Testing that password contains at least One numeric char
        [Theory]
        [InlineData("TESTPASSn", false)]
        [InlineData("tESTPASS8", true)]

        public void TestPassNumeric(string v, bool expected)
        {
            bool actual = PasswordVerifier.IsNumeric(v);
            Assert.Equal(expected, actual);
        }

        //Testing that password is > 8 chars, contains at least One UpperCase, at least one LowerCase letter
        [Theory]
        [InlineData("testpas8", false)]
        [InlineData("TESTPASS8", false)]
        [InlineData("testpass8", false)]
        [InlineData("tESTPASS8", true)]

        public void TestPass8UpLow(string v, bool expected)
        {
            bool actual = PasswordVerifier.Is8UpLow(v);
            Assert.Equal(expected, actual);
        }

        //Testing that password is > 8 chars, contains at least One UpperCase, at least one numeric char
        [Theory]
        [InlineData("testpas8", false)]
        [InlineData("TESTPASSn", false)]
        [InlineData("testpass8", false)]
        [InlineData("tEstpass8", true)]

        public void TestPass8UpNum(string v, bool expected)
        {
            bool actual = PasswordVerifier.Is8UpNum(v);
            Assert.Equal(expected, actual);
        }
    }
}
