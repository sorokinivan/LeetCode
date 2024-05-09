namespace Task66
{
    internal class Program
    {
        public static int[] PlusOne(int[] digits)
        {
            var length = digits.Length;
            digits[length - 1]++;
            if (digits[length - 1] > 9 )
            {
                for(int i = length - 1; i >= 0; i--)
                {
                    if(digits[i] > 9)
                    {
                        digits[i] = 0;
                        if(i - 1 < 0)
                        {
                            var result = new int[length+1];
                            result[0] = 1;
                            digits[0] = 0;
                            for(int j = 1; j < length + 1; j++)
                            {
                                result[j] = digits[j-1];
                            }
                            return result;
                        }
                        digits[i - 1]++;
                    }
                }
            }
            return digits;
            //var last = ++digits[length - 1];
            //if(last/10 > 0)
            //{
            //    if (length > 1)
            //    {
            //        digits[length - 1] = 0;
            //    }

            //    for(int i = length - 2; i >=0; i--)
            //    {
            //        digits[i]++;
            //        if (digits[i]/10 == 0)
            //        {
            //            break;
            //        }
            //    }
            //}
            //else
            //{
            //    digits[length - 1] = last;
            //}
            //if (digits[0]/10 > 0)
            //{
            //    var result = new int[length+1];
            //    result[0] = 1;
            //    result[1] = 0;
            //    for(int i = 2; i < length; i++)
            //    {
            //        result[i] = digits[i - 1];
            //    }
            //    return result;
            //}
            //return digits;
        }
        static void Main(string[] args)
        {
            var t = PlusOne(new int[] {9,9,9});
            Console.WriteLine("Hello, World!");
        }
    }
}
