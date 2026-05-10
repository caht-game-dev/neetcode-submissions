public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int need = target - numbers[i];

            if (dict.ContainsKey(need))
            {
                return new int[] { dict[need], i+1};
            }
            var tmp = i+1;

            dict[numbers[i]] = tmp;
        }

        return new int[] { };
    }
}