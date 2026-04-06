namespace Best_Time_to_Buy_And_Sell_Stock
{
    public class Solution
    {
        /// <summary>
        /// 暴力版
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 0; prices.Length > i; i++) 
            {
                int buyPrice = prices[i];
                for (int j = i +1 ; prices.Length > j; j++) 
                {
                    int sellPrice = prices[j];
                    int profit = sellPrice - buyPrice;
                    maxProfit = (sellPrice - buyPrice) > maxProfit ? sellPrice - buyPrice : maxProfit;
                }
                
            }

            return maxProfit;
        }
    }


    internal class Program
    {



        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] price = [6];
            price = [10, 1, 5, 6, 7, 1];
            var result = solution.MaxProfit(price);
            Console.WriteLine($"最大獲利：{result}");
        }
    }
}
