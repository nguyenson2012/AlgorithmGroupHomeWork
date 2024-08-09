//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

/*
+ To choose the time to buy is at idx 0
+ From idx 1 to end
    + Always count the profit => if cur profit is larger than result => update result
    + if the time to buy is smaller than cur value => update buy time

Space complexity: O(1)
Time complexity: O(n)
*/

namespace Day2307
{
    public class Exercise3
    {
        public int MaxProfit(int[] prices)
        {
            int result = 0;
            int length = prices.Length;

            if (length == 1) return result;

            int buy = prices[0];

            foreach (int price in prices)
            {
                int count = price - buy;

                result = Math.Max(result, count);
                buy = Math.Min(buy, price);
            }

            return result;
        }
    }
}