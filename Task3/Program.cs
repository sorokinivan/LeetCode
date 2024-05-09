namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var set = new List<char>();
            var s = "abcabcbb";
            var result = 0;
            var index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!set.Contains(s[i]))
                {
                    set.Add(s[i]);
                }
                else
                {
                    result = Math.Max(result, set.Count);
                    index = set.IndexOf(s[i]);
                    set.RemoveRange(0, index+1);
                    set.Add(s[i]);
                }
            }
            var t = set.Count;
            Console.WriteLine(set.FirstOrDefault());
            Console.WriteLine("Hello, World!");
        }
    }
}
