using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordVerifier_Kata
{
    public class PasswordVerifier
    {
        // Is the password chosen at least 8 chars long?

        public static bool Is8Chars(string p)
        {
            if (p.Length > 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Does password contain null or whitespace?

        public static bool IsPassNull(string p)
        {
            if (string.IsNullOrEmpty(p) || string.IsNullOrWhiteSpace(p))  //(p == "" || p.Any(char.IsWhiteSpace)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Does password contain at Least ONE UPPERCASE letter?

        public static bool IsUpperCase(string p)
        {
            if (p.Any(char.IsUpper))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Does password contain at Least ONE LowerCase letter?

        public static bool IsLowerCase(string p)
        {
            if (p.Any(char.IsLower))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Does password contain at Least ONE numeric char?

        public static bool IsNumeric(string p)
        {
            if (p.Any(char.IsNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Does password contain at Least three requirements?

        public static bool Is8UpLow(string p)
        {
            if (p.Length > 8 && p.Any(char.IsUpper) && p.Any(char.IsLower))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Does password contain at Least three requirements?

        public static bool Is8UpNum(string p)
        {
            if (p.Length > 8 && p.Any(char.IsUpper) && p.Any(char.IsNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Main Password funtion

        public static void Verify(string p)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(p) || string.IsNullOrWhiteSpace(p))
                {
                    Console.WriteLine("Passwords can't be blank or contain spaces. Please try again!");
                    Console.Write("Please enter a new password: ");
                    p = Console.ReadLine();
                }
                else
                {

                }
                if (p.Length <= 8)
                {
                    Console.WriteLine("Passwords must be more than 8 characters in length. Please try again!");
                    Console.Write("Please enter a new password: ");
                    p = Console.ReadLine();
                }

                if (!p.Any(char.IsUpper))
                {
                    Console.WriteLine("Passwords must contain at least one Uppercase letter. Please try again!");
                    Console.Write("Please enter a new password: ");
                    p = Console.ReadLine();
                }
                if (!p.Any(char.IsLower))
                {
                    Console.WriteLine("Passwords must contain at least one lowercase letter. Please try again!");
                    Console.Write("Please enter a new password: ");
                    p = Console.ReadLine();
                }
                if (!p.Any(char.IsNumber))
                {
                    Console.WriteLine("Passwords must contain at least one numeric character. Please try again!");
                    Console.Write("Please enter a new password: ");
                    p = Console.ReadLine();
                }
                if (p.Length > 8 && p.Any(char.IsUpper) && p.Any(char.IsLower) && p.Any(char.IsNumber))
                {
                    return ;
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("You are required to update your password: ");
                string pass = Console.ReadLine();
                PasswordVerifier.Verify(pass);
                Console.WriteLine("Thank you! Your password has been accepted.\nGoodbye!");
                break;
            }
        }
    }
}
