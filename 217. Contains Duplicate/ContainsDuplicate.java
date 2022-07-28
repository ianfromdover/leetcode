import java.util.Set;
import java.util.HashSet;

class Solution {
    public boolean containsDuplicate(int[] nums) {
        Set<Integer> s = new HashSet<>();
        for (int i = 0; i < nums.length; i++) {
            int curr = nums[i];
            if (s.contains(curr)) {
                return true;
            } else {
                s.add(curr);
            }
        }
        return false;
    }
}
