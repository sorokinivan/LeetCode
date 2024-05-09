namespace Task13
{
    internal class Program
    {
        static Dictionary<char, int> chars = new Dictionary<char, int>() 
        { 
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };
        public static int RomanToInt(string s)
        {
            var result = 0;
            for(int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'M':
                        {
                            result += 1000;
                            break;
                        }
                    case 'D':
                        {
                            result += 500;
                            break;
                        }
                    case 'C':
                        {
                            if (i+1 < s.Length && s[i + 1] == 'M')
                            {
                                result += 900;
                                i++;
                            }
                            else if (i + 1 < s.Length && s[i + 1] == 'D')
                            {
                                result += 400;
                                i++;
                            }
                            else
                            {
                                result += 100;
                            }
                            
                            break;
                        }
                    case 'L':
                        {
                            result += 50;
                            break;
                        }
                    case 'X':
                        {
                            if (i + 1 < s.Length && s[i + 1] == 'L')
                            {
                                result += 40;
                                i++;
                            }
                            else if (i + 1 < s.Length && s[i + 1] == 'C')
                            {
                                result += 90;
                                i++;
                            }
                            else
                            {
                                result += 10;
                            }
                            break;
                        }
                    case 'V':
                        {
                            result += 5;
                            break;
                        }
                    case 'I':
                        {
                            if (i + 1 < s.Length && s[i + 1] == 'V')
                            {
                                result += 4;
                                i++;
                            }
                            else if (i + 1 < s.Length && s[i + 1] == 'X')
                            {
                                result += 9;
                                i++;
                            }
                            else
                            {
                                result += 1;
                            }
                            break;
                        }
                }
                
            }
            return result;
        }
        static void Main(string[] args)
        {
            RomanToInt("MCMXCIV");
            Console.WriteLine("Hello, World!");
        }
    }
}
