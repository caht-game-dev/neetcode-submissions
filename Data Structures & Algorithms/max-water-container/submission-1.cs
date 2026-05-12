public class Solution 
{
    public int MaxArea(int[] heights) 
    {
        int l = 0;
        int r = heights.Length - 1;
        int res = 0;

        while (l < r)
        {
            int width = r - l;
            int minHeight = Math.Min(heights[l], heights[r]);

            res = Math.Max(res, width * minHeight);

            if (heights[l] < heights[r])
                l++;
            else
                r--;
        }

        return res;
    }
}