public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var match = new Dictionary<int, int>();
        int[] output = new int[2];

        for(int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if(match.ContainsKey(diff)) {
                output[0] = match[diff];
                output[1] = i;
                return output;
            }
            match[nums[i]] = i;
        }
        return new int[2];
    }
}
