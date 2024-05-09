using System.Linq.Expressions;

namespace Task125
{
    internal class Program
    {
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return true;
            }
            char[] arr = s.ToCharArray();

            arr = Array.FindAll<char>(arr, c => char.IsLetterOrDigit(c));
            s = new string(arr);
            Array.Reverse(arr);
            var reversed = new string(arr);
            return reversed.ToLower() == s.ToLower();
        }
        static void Main(string[] args)
        {
            var t = IsPalindrome("A man, a plan, a canal: Panama");
            Console.WriteLine("Hello, World!");
        }
    }
}
