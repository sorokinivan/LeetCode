namespace Task392
{
    internal class Program
    {
        public static bool IsSubsequence(string s, string t)
        {
            var index = 0;
            foreach(var c in s)
            {
                index = t.IndexOf(c, index);
                if (index == -1)
                {
                    return false;
                }
                else
                {
                    index++;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            var t = IsSubsequence("abc", "ahbgdc");
            Console.WriteLine("Hello, World!");
        }
    }
}
