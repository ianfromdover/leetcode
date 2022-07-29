public class Solution {
    public int[] RunningSum(int[] nums) {
        int len = nums.Length;
        int[] result = new int[len];
        result[0] = nums[0];
        for (int i = 1; i < len; i++) {
            result[i] = nums[i] + result[i - 1];
        }
        return result;
    }
}
