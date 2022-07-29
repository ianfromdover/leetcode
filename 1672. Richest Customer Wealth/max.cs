public class Solution {
    public int MaximumWealth(int[][] accounts) => accounts.Max(customer => customer.Sum());
}
