namespace Task169
{
    internal class Program
    {
        public static int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length / 2];
            //return nums.GroupBy(x => x).OrderByDescending(x => x.Count()).FirstOrDefault().Key;
        }
        static void Main(string[] args)
        {
            MajorityElement(new int[] { 3,2,3});
            Console.WriteLine("Hello, World!");
        }
    }
}
