namespace Task27
{
    internal class Program
    {
        public static int RemoveElement(int[] nums, int val)
        {
            var end = nums.Length - 1;
            var bag = 0;
            while (end >= 0)
            {
                if (end != 0 && nums[end] != val)
                {
                    if (nums[end-1] != val)
                    {
                        bag = nums[end - 1];
                        nums[end] = val;
                    }
                    else
                    {
                        nums[end - 1] = nums[end];
                        nums[end] = val;
                    }
                }
                end--;
            }
            var t = 0;
            return 0;
        }
        static void Main(string[] args)
        {
            RemoveElement(new int[] { 3, 2, 2, 3 }, 3);
            Console.WriteLine("Hello, World!");
        }
    }
}
