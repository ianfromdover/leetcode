public class Solution {
    public int[] RunningSum(int[] nums) {
        if (nums.Length > 1)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                int temp = nums[i];
                nums[i] = temp + nums[i - 1];
            }
        }
        return nums;
    }
}
