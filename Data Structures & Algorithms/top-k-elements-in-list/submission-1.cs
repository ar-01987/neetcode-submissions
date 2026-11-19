public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int, int>();
        int[] output = new int[k];
        int n = nums.Length;

        for(int i = 0; i < n; i++) {
            freqMap[nums[i]] = freqMap.GetValueOrDefault(nums[i]) + 1;
        }
        
        var freq = new List<int>[n + 1];
        foreach(var pair in freqMap) {
            int count = pair.Value;
            if(freq[count] == null) freq[count] = new List<int>();
            freq[count].Add(pair.Key);
        }

        int pos = 0;
        for(int j = freq.Length - 1; j > 0 && k > pos; j--) {
            if(freq[j] == null) continue;
            foreach(int num in freq[j]) {
                output[pos++] = num;
                if(pos == k) break;
            }
        }
        return output;
    }
}
