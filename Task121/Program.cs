namespace Task121
{
    internal class Program
    {
        public static int MaxProfit(int[] prices)
        {
            var max = Array.IndexOf(prices, prices.Max());
            var newArray = prices.Take(max).ToArray();
            if(newArray.Length == 0)
            {
                return 0;
            }
            var min = Array.IndexOf(newArray, newArray.Min());
            var res = prices[max] - newArray[min];
            return res;
        }
        static void Main(string[] args)
        {
            var t = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            Console.WriteLine("Hello, World!");
        }
    }
}
