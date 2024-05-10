namespace Task28
{
    internal class Program
    {
        public static int StrStr(string haystack, string needle)
        {
            if(needle.Length > haystack.Length)
            {
                return -1;
            }
            if(haystack == needle)
                return 0;
            var index = 0;
            var res = -1;
            for(int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[index])
                {
                        index++;
                        if (index == needle.Length)
                            return i - index + 1;

                }
                else
                {
                    i -= index;
                    index = 0;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            var t = StrStr("mississippi", "issip");
            Console.WriteLine("Hello, World!");
        }
    }
}
