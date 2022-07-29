public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int a = 1;
        foreach (var e in accounts)
            a = Math.Max(a, e.Sum());
        return a;
    }
}
