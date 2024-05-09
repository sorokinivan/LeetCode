namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            var newTarget = target;
            var second = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                newTarget = target - nums[i];
                second = Array.LastIndexOf(nums, newTarget);
                if(second > 0 && second != i)
                {
                    result[0] = i;
                    result[1] = second;
                    break;
                }
                else
                {
                    continue;
                }
            }
            return result;
        }
    }
}
