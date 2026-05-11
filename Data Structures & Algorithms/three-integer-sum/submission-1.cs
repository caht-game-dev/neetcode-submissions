public class Solution 
{
    public List<List<int>> ThreeSum(int[] nums) 
    {
        Array.Sort(nums);

        List<List<int>> res = new();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int l = i + 1;
            int r = nums.Length - 1;

            while (l < r)
            {
                int sum = nums[i] + nums[l] + nums[r];

                if (sum == 0)
                {
                    res.Add(new List<int> { nums[i], nums[l], nums[r] });

                    int leftVal = nums[l];
                    int rightVal = nums[r];

                    while (l < r && nums[l] == leftVal) l++;
                    while (l < r && nums[r] == rightVal) r--;
                }
                else if (sum < 0)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
        }

        return res;
    }
}