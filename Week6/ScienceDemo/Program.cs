using System;

namespace ScienceDemo
{
    public class Program
    {

        // Rate times time = distance
        // time = distance / rate
        //
        // RT=D
        //  R+ D / T   miles per hour (km per hour)

        static public double TimeUntilTouchdown(double D, double R)
        {
            return D / R;
        }

        static public bool IsFibonacci(int num)
        {
            // Start listing Fibanocci numbers
            // If we find the number we're looking for,
            // then return true (it is in the list)
            // if we get to a number greater than the one we're 
            // looking for, then return false (it's NOT in the list)

            if (num == 0 || num == 1)
            {
                return true;
            }

            int prev1 = 1;
            int prev2 = 1;
            

            while (true)
            {
                int fib = prev1 + prev2;
                if (num == fib)
                {
                    return true;
                }
                if (fib > num)
                {
                    return false;
                }

                // end of loop
                prev1 = prev2;
                prev2 = fib;
            }

        }

        public static int GetNthFib(int lookingfor)
        {

            if (lookingfor == 1)
            {
                return 0;
            }
            if (lookingfor == 2)
            {
                return 1;
            }
            // 1 wiil return 0
            // 2 will return 1
            // 3 will return 1
            // 4 will return 2
            // 5 will return 3
            int current = 0;  // The current number we're testing
            int howmany = 0;  // How many fib numbers we've found
            lookingfor--;
            while (true)
            {
                // Right now we don't need to worry about how
                // to tell if a number is a Fib number, we 
                // just call it.
                if (IsFibonacci(current))
                {
                    howmany++;
                    if (howmany == lookingfor)
                    {
                        return current;
                    }
                }
                current++;
            }
        }


        static void Main(string[] args)
        {

            // At this point I switch my focus FROM
            // "building" my Fib functions
            // TO
            // "USING" my Fib functions

            Console.Write("Which number Fibonacci would you like? ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetNthFib(num));
        }
    }
}
