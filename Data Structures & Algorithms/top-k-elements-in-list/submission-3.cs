public class Solution {
     public int[] TopKFrequent(int[] nums, int k)
     {
          Dictionary<int, int> count = new Dictionary<int, int>();
          List<int>[]          freq  = new List<int>[nums.Length + 1];


          foreach (int n in nums) {
               if (count.ContainsKey(n)) {
                    count[n]++;
               } else {
                    count[n] = 1;
               }
          }
          foreach (var entry in count){
               if (freq[entry.Value] == null) freq[entry.Value] = new List<int>();
               freq[entry.Value].Add(entry.Key);
          }
          
          int[] res   = new int[k];
          int   index = 0;
          for (int i = freq.Length - 1; i > 0 && index < k; i--) {
               if (freq[i] == null) continue;
               foreach (int n in freq[i]) 
               {
                    res[index++] = n;
                    if (index == k) {
                         return res;
                    }
               }
          }
          return res;
     }
}