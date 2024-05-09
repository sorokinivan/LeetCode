using System.Text;

namespace Task7
{
    internal class Program
    {
        public static int Reverse(int x)
        {
            var result = 0;
            var remain = 0;
            var temp = 0;
            while (x != 0)
            {
                remain = x % 10;
                temp = result * 10 + remain;

                if ((temp - remain) / 10 != result)
                {
                    return 0;
                }

                result = temp;
                x /= 10;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Reverse(-123);
            Console.WriteLine("Hello, World!");
        }
    }
}
