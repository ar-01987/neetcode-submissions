public class Solution {
    public bool hasDuplicate(int[] nums) {
        var seen = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            if(!seen.ContainsKey(nums[i])) {
                seen[nums[i]] = 1;
            } else {
                return true;
            }
        }
        return false;
    }
}