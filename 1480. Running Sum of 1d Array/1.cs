public class Solution {
    public int[] RunningSum(int[] nums) {
        int len = nums.Length;
        int[] result = new int[len];
        for (int i = 0; i < len; i++) {
            for (int j = 0; j <= i; j++) {
                result[i] += nums[j];
            }
        }
        return result;
    }
}
