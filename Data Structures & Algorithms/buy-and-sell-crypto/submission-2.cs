public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int maxProfit  = 0;
        for(int j=0; j<prices.Length; j++)
        {
            if(prices[j] < minPrice)
            {
                minPrice = prices[j];
            }
            else maxProfit = Math.Max(maxProfit, prices[j]-minPrice);
        }
        return maxProfit;
    }
}
