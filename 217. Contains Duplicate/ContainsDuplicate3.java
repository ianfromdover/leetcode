import java.util.HashSet;

class Solution {
    public boolean containsDuplicate(int[] nums) {
        List<Integer> n = Arrays.stream(nums)
                            .boxed()
                            .toList();
        HashSet<Integer> s = new HashSet<>(n);
        return s.size() < nums.length;
    }
}
