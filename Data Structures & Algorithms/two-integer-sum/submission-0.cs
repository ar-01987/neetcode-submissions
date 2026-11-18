public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int, int>(nums.Length);
        int[] sum = {0,0};
        for(int i = 0; i < nums.Length; i++) {
            int needs = target - nums[i];
            if(seen.ContainsKey(needs)) {
                sum[0] = seen[needs];
                sum[1] = i;
                break;
            }
            seen[nums[i]] = i;
        }
        return sum;
    }
}
