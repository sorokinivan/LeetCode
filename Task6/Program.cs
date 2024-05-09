using System.Text;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = Convert("ab", 2);
            Console.WriteLine("Hello, World!");
        }

        public static string Convert(string s, int numRows)
        {
            if(numRows > 1)
            {
                var resultArray = new StringBuilder[numRows];
                for(int i = 0; i < numRows; i++)
                {
                    resultArray[i] = new StringBuilder();
                }
                var index = 0;
                var down = false;
                for (int i = 0; i < s.Length; i++)
                {
                    resultArray[down ? --index : index++].Append(s[i]);
                    if (index >= numRows)
                    {
                        down = true;
                        index--;
                    }
                    else if (index <= 0)
                    {
                        down = false;
                        index++;

                    }
                }
                StringBuilder res = new();
                for (int i = 0; i < resultArray.Length; i++)
                {
                    res.Append(resultArray[i]);
                }
                return res.ToString();
            }
            else
            {
                return s;
            }
            
        }
    }
}
