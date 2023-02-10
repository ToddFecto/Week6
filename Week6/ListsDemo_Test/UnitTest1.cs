using System;
using Xunit;
using ListsDemo;
using System.Collections.Generic;
namespace ListsDemo_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new string[] { "a", "b" }, 4)]
        [InlineData(new string[] { "a", "b", "c" }, 6)]
        [InlineData(new string[] { "x", "y", "z" }, 6)]
        public void Test1(string[] items, int expected)
        {
            // We can only include arrays not lists in the InlineData
            // So make a list from the array
            List<string> mylist = new List<string>(items);
            Stuff st = new Stuff();
            int actual = st.UseList(mylist);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new string[] { }, 0)]
        [InlineData(new string[] { "a" }, 2)]
        [InlineData(new string[] { "x", "y", "z" }, 6)]
        [InlineData(new string[] { "a", "b", "c", "d", "e" }, 10)]
        [InlineData(new string[] { "a", "b", "c", "d", "e", "f" }, 12)]
        [InlineData(new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" }, 20)]
        [InlineData(new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k" }, 22)]

        public void TestisDogHappy(string[] dogtoys, int expected)
        {
            List<string> PetToys = new List<string>(dogtoys);
            Stuff dt = new Stuff();
            int actual = dt.UseList(PetToys);
            Assert.Equal(expected, actual);
        }
    }
}
