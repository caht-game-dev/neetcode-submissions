public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        int res = 0;

        HashSet<int> set = new HashSet<int>();

        foreach (var n in nums)
        {
            set.Add(n);
        }

        foreach (var s in set)
        {
            if (!set.Contains(s - 1))
            {
                int i = 1;

                while (set.Contains(s + i))
                {
                    i++;
                }

                res = Math.Max(res, i);
            }
        }

        return res;
    }
}