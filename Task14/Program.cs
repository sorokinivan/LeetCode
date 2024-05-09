using System.Text;

namespace Task14
{
    internal class Program
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1 || strs.All(x => x == strs[0]))
            {
                return strs[0];
            }
            
            var shortest = strs.OrderBy(str => str.Length).FirstOrDefault();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < shortest.Length; i++)
            {
                var t = strs.Select(s => s[i]).ToList();
                if(strs.All(x => x.IndexOf(shortest[i],i) == i)){
                    sb.Append(shortest[i]);
                }
                else
                {
                    break;
                }
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            var t = LongestCommonPrefix(new string[] { "aaa", "aa", "aaa"});
            Console.WriteLine("Hello, World!");
        }
    }
}
