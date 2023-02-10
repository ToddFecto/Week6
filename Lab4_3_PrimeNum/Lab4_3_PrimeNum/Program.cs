using System;
using System.Collections.Generic;

namespace Lab4_3_PrimeNum
{
    public class PrimeNumbers
    {
        // Is it a Prime number?

        public static bool IsPrime(int n)
        {
            if (n == 0 || n == 1)       // Covers special cases equal to 0 OR 1
            {
                return false;
            }

            if (n == 2 || n == 3 || n == 5 || n == 7)       // Covers special cases equal to 2, 3, 5, & 7 
            {
                return true;
            }

            if (n % 2 == 0)     // Covers test for all EVEN numbers
            {
                return false;
            }
            else
            {
                for (int i = 3; i <= Math.Sqrt(n); i += 2)  //   Starts counting at 3 and increments by 2 for ODD #'s, since all EVEN numbers are previously checked.
                {
                    if (n % i == 0)     // Replaces individual cases for: (n % 2 == 0), (n % 3 == 0), (n % 5 == 0), (n % 7 == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static int GetPrime(int PrimeLookingFor)
        {
            int current = 0;    // Current number being checked
            int found = 0;  //Primes found

            while (true)
            {
                if (IsPrime(current))
                {
                    found++;
                    if (found == PrimeLookingFor)
                    {
                        return current;
                    }
                }
                current++;
            }
        }
    }


    class Program
    {
        static bool CalcPrimeNumbers()
        {
            while (true)
            {
                Console.Write("\n\nContinue? (y/n): ");                        //Prompts for user input to continue or not
                string moreNumbers = Console.ReadLine();
                moreNumbers = moreNumbers.ToLower();                           //Converts input case to only lower case

                if (moreNumbers == "y" || moreNumbers == "yes")                //Checks the condition to continue measuring rooms or quit
                {
                    return true;
                }
                else if (moreNumbers == "n" || moreNumbers == "no")
                {
                    return false;
                }
                else
                {
                    Console.Write("Please enter only y or n!");                //Prompts user to only enter a y (yes ) or n (no) if another character is entered
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Let's locate some primes!\nThis application will find you any prime, in order, from first prime number on.");
            do
            { 
            Console.Write("\nWhich prime number (nth) place do you want to see? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Prime number {n} is {PrimeNumbers.GetPrime(n)}.");
            }while (CalcPrimeNumbers());

            Console.WriteLine("\nGoodbye!");
        }
    }
}
