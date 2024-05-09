using System.Text;

namespace Task12
{
    internal class Program
    {
        static Dictionary<int,string> map = new Dictionary<int, string>() 
        {
            {1000, "X" },
            {900, "CM" },
            {500, "D" },
            {400, "CD" },
            {100, "C" },
            {90, "XC" },
            {50, "L" },
            {40, "XL" },
            {10, "X" },
            {9, "IX" },
            {5, "V" },
            {4, "IV" },
            {1, "I" },
        };
        public static string IntToRoman(int num)
        {
            StringBuilder sb = new StringBuilder();
            while (num > 0)
            {
                if (num - 1000 > 0)
                {
                    num = num - 1000;
                    sb.Append('M');
                }
                else if (num - 900 >= 0)
                {
                    num = num - 900;
                    sb.Append("CM");
                }
                else if (num - 500 >= 0)
                {
                    num = num - 500;
                    sb.Append('D');
                }
                else if (num - 400 >= 0)
                {
                    num = num - 400;
                    sb.Append("CD");
                }
                else if (num - 100 >= 0)
                {
                    num = num - 100;
                    sb.Append('C');
                }
                else if (num - 90 >= 0)
                {
                    num = num - 90;
                    sb.Append("XC");
                }
                else if (num - 50 >= 0)
                {
                    num = num - 50;
                    sb.Append('L');
                }
                else if (num - 40 >= 0)
                {
                    num = num - 40;
                    sb.Append("XL");
                }
                else if (num - 10 >= 0)
                {
                    num = num - 10;
                    sb.Append('X');
                }
                else if (num - 9 >= 0)
                {
                    num = num - 9;
                    sb.Append("IX");
                }
                else if (num - 5 >= 0)
                {
                    num = num - 5;
                    sb.Append('V');
                }
                else if (num - 4 >= 0)
                {
                    num = num - 4;
                    sb.Append("IV");
                }
                else
                {
                    num = num - 1;
                    sb.Append('I');
                }
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            IntToRoman(3749);
            Console.WriteLine("Hello, World!");
        }
    }
}
