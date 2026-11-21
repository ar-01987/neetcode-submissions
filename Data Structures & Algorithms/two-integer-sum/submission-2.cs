public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var match = new Dictionary<int, int>();
        int[] output = new int[2];

        for(int i = 0; i < nums.Length; i++) {
            int missing = target - nums[i];
            if (match.ContainsKey(missing)) {
                output[0] = match[missing];
                output[1] = i;
                break;
            }
            match.Add(nums[i], i);
        }
        return output;
    }
}
