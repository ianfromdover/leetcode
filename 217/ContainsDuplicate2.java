import java.util.HashSet;

class Solution {
    public boolean containsDuplicate(int[] nums) {
        HashSet<Integer> s = new HashSet<>();
        for (int i = 0; i < nums.length; i++) {
            int curr = nums[i];
            if (!s.add(curr)) {
                return true;
            }
        }
        return false;
    }
}
