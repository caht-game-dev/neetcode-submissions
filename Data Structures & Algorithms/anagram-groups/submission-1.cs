public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var res = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var array = new int[26];
            foreach(var s in str)
            {
                array[s - 'a']++;
            }
            var tmp = string.Join(",", array);
            if (!res.ContainsKey(tmp))
            {
                res[tmp] = new List<string>();
            }
            res[tmp].Add(str);
        }

        return res.Values.ToList();
    }
}
