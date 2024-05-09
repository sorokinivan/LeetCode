using System;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = IsPalindrome(121);
            Console.WriteLine("Hello, World!");
        }
        public static bool IsPalindrome(int x)
        {
            if(x == 0 || x > 0 && x < 9)
            {
                return true;
            }
            var num = x;
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return x == result;
        }
    }
}
