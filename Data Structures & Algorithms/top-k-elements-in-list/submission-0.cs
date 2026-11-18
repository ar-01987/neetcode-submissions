public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int, int>();
        int[] output = new int[k];
        int n = nums.Length;

        for(int i = 0; i < n; i++) {
            freqMap[nums[i]] = freqMap.GetValueOrDefault(nums[i]) + 1;
        }
        
        var frequencies = new List<int>[n + 1];
        foreach(var pair in freqMap) {
            int count = pair.Value;
            if(frequencies[count] == null) frequencies[count] = new List<int>();
            frequencies[count].Add(pair.Key);
        }

        int pos = 0;
        for(int j = frequencies.Length - 1; j >= 1 && pos < k; j--) {
            if(frequencies[j] == null) continue;
            foreach(int num in frequencies[j]) {
                output[pos++] = num;
                if (pos == k) break;
            }
        }

        return output;
    }
}
