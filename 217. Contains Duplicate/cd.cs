public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        // learn set in C#
        // learn all data structures and algos in C# for implementation
        HashSet<int> s = new HashSet<int>();
        foreach (int curr in nums) {
            if (!s.Add(curr)) {
                return true;
            }
        }
        return false;
    }
}
