namespace Task58
{
    internal class Program
    {
        public static int LengthOfLastWord(string s)
        {
            s = s.Trim();
            var t = s.Length - 1;
            

            for (int i = t; i > 0; i--)
            {
                if (s[i] == ' ')
                {
                    return t - i;
                }
            }
            return t+1;
        }
        static void Main(string[] args)
        {
            var t = LengthOfLastWord("a");
            Console.WriteLine("Hello, World!");
        }
    }
}
