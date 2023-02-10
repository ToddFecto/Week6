using System;

namespace MathDemo
{
    public class Program
    {
        public static bool IsCoupon(decimal spent)
        {
            // If they spend $10 or more, they get a $3 off coupon
            if (spent >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int BigFormula(int x, int y, int z)
        {
            int num1 = Add(x, y);
            int num2 = Subtract(num1, z);
            return num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {


            Console.WriteLine("Hello");
        }
    }
}
