using System;
using System.Collections.Generic;
using System.Text;

namespace DogApp
{
	public class Dog
	{
		public static bool IsItABigDoggo(int num)
		{
			if (num >= 40)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public int DogHappiness(List<string> toys)
		{
			int happinessMeter = 0;
			if (toys.Count >= 10)
			{
				happinessMeter = 3;
			}
			if (toys.Count >= 5)
			{
				happinessMeter = 2;
			}
			if (toys.Count >= 1)
			{
				happinessMeter = 1;
			}
			return happinessMeter;
		}
		//Tests with the same List<string> as DogHappiness() above
		public int UseList(List<string> MyList)
		{
			return MyList.Count * 2;
		}

		public static string DogGreeting(string animal)
		{
			string greeting = "";

			if (animal == "bear")
			{
				greeting = "Grrr";
			}
			if (animal == "dog")
			{
				greeting = "kisses";
			}
			if (animal == "cat")
			{
				greeting = "WOOF";
			}

			return greeting;
		}

		public static string DogHobby(string hobby)
		{
			//Console.WriteLine("What is your favorite hobby, doggy?");
			//string hobby = Console.ReadLine();

			//return "The dog's favorite hobby is " + hobby + ".";
			string reaction = "";

			if (hobby == "chewing toy")
			{
				reaction = "tail wagging";
			}
			if (hobby == "eating")
			{
				reaction = "lapping mouth";
			}
			if (hobby == "bath")
			{
				reaction = "splashing";
			}

			return reaction;
		}
	}
}

