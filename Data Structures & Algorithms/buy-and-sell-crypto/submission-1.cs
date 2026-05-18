public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int l = 0;
        int res = 0;
        int i = 1;

        while (i < prices.Length)
        {
            if (prices[l] > prices[i])
            {
                l = i;
            }
            else
            {
                res = Math.Max(prices[i] - prices[l], res);
            }


            i++;
        }

        return res;
    }
}