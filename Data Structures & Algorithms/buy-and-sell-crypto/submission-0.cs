public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int l = 0;
        int res = 0;

        for(int i = 1; i < prices.Length; i++)
        {
            if(prices[l] > prices[i])
            {
                l = i;
            }

            res = Math.Max(prices[i] - prices[l], res);
        }

        return res;
    }
}
