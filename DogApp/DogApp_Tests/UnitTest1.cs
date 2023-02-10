using System;
using Xunit;
using DogApp;
using System.Collections.Generic;

namespace DogApp_Tests
{
    public class UnitTest1
    {
        //Testing to see if the dog is a big one
        [Theory]
        [InlineData(0, false)]
        [InlineData(1, false)]
        [InlineData(10, false)]
        [InlineData(40, true)]
        [InlineData(50, true)]

        public void TestisBigDog(int num, bool expected)
        {
            bool actual = Dog.IsItABigDoggo(num);
            Assert.Equal(expected, actual);
        }

        //Testing to see the dog's level of Happiness using [Fact]
        //[Fact]
        //public void TestisDogHappy()
        //{
        //    Dog d = new Dog();
        //    List<string> toys = new List<string>() { "a", "b", "c", "d", "e", "f", "a", "b", "c", "d", "e", "f" };

        //    int actual = Dog.DogHappiness(toys);
        //    int expected = 3;
        //    Assert.Equal(expected, actual);
        //}

        //Testing to see the dog's level of Happiness using [Theory]
        [Theory]
        [InlineData(new string[] { }, 0)]
        [InlineData(new string[] { "a" }, 1)]
        [InlineData(new string[] { "x", "y", "z" }, 1)]
        [InlineData(new string[] { "a", "b", "c", "d", "e" }, 2)]
        [InlineData(new string[] { "a", "b", "c", "d", "e", "f"}, 2)]
        [InlineData(new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" }, 3)]
        [InlineData(new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k" }, 3)]

        public void TestisDogHappy(string[] dogtoys, int expected)
        {
            List<string> PetToys = new List<string>(dogtoys);
            Dog dt = new Dog();
            int actual = dt.DogHappiness(PetToys);
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

        public void UseList(string[] dogtoys, int expected)
        {
            List<string> PetToys = new List<string>(dogtoys);
            Dog dt = new Dog();
            int actual = dt.UseList(PetToys);
            Assert.Equal(expected, actual);
        }

        //Testing to see if animal greetings are as expected
        [Theory]
        [InlineData("bear", "Grrr")]
        [InlineData("dog", "kisses")]
        [InlineData("cat", "Meow")]
        [InlineData("cat", "WOOF")]

        public void TestAnimalGreeting(string animal, string expected)
        {
            string actual = Dog.DogGreeting(animal);
            Assert.Equal(expected, actual);
        }

        //Testing to see if animal greetings are as expected
        [Theory]
        [InlineData("chewing toy", "tail wagging")]
        [InlineData("eating", "lapping mouth")]
        [InlineData("bath", "splashing")]
        [InlineData("bath", "howling")]

        public void TestAnimalHobby(string hobby, string expected)
        {
            string actual = Dog.DogHobby(hobby);
            Assert.Equal(expected, actual);
        }
    }
}
