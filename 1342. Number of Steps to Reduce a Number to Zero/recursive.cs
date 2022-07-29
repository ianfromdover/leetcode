public class Solution {
    public int NumberOfSteps(int num)
    {
        return Helper(num, 0);
    }
    
    public static int Helper(int num, int steps)
    {
        if (num == 0)
        {
            return steps;
        }
        else if (num % 2 == 0)
        {
            return Helper(num / 2, steps + 1);
        }
        else
        {
            return Helper(num - 1, steps + 1);
        }
    }
}
