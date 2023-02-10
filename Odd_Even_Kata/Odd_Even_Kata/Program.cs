using System;
using System.Collections.Generic;

namespace Odd_Even_Kata
{
    public class OddEvenPrime
    {
        // Is it an EVEN number OR an ODD number or an ODD & PRIME number?

        public static bool IsEven(int n)   // Checks for EVEN numbers
        {
            if (n < 2)
            {
                return false;
            }

            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsOdd(int n)     // Checks for ODD numbers
        {
            if (n < 1)
            {
                return false;
            }

            if (n % 2 != 0)
            {
                return true; 
            }
            return false;
        }

        

        public static bool IsPrime(int n)       // Checks for a Prime number?
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
                for (int i = 3; i <= Math.Sqrt(n); i += 2)  //for (int i = n; i <= n; i++)  << still produced errors/failed tests
                {
                    if (n % i == 0)     // Replaces individual cases for: (n % 2 == 0), (n % 3 == 0), (n % 5 == 0), (n % 7 == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void PrintAllNums(int NumToPrint)
        {
            int current = 0;    // Current number being checked

            for (current = 1; current < NumToPrint + 1; current++)
            {
                if (IsPrime(current))
                {
                    {
                        Console.WriteLine($"{current} = PRIME");
                    }
                }
                else if (IsOdd(current))
                {
                    Console.WriteLine($"{current} = ODD");
                }
                else
                {
                    Console.WriteLine($"{current} = EVEN");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 100; // Initializes NumToPrint to count up to.

            OddEvenPrime.PrintAllNums(i);


        }
    }
}
