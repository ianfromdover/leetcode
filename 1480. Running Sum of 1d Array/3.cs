public class Solution {
    public int[] RunningSum(int[] nums) {
        int j, prev, len;
        j = prev = 0;
        len = nums.Length;
        int[] result = new int[len];
        
        do {
            prev += nums[j];
            result[j] = prev;
            j++;
        } while (j < len);
        return result;
    }
}
