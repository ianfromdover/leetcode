public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if (n == 0)
        {
            return true;
        }
        // else if (n > Math.Ceiling((double) (flowerbed.Length / 2)))
        else if (n >= flowerbed.Length)
        {
            return false;
        }
        
        int capacity = 0;
        
        for (int i = 0; i < flowerbed.Length; i++)
        {
            // check adj for flower
            for (int j = i - 1; j < i + 2; j++)
            {
                if (!WithinBounds(flowerbed.Length, j))
                {
                    continue;
                }
                
                if (flowerbed[j] == 1)
                {
                    break;
                }
                
                if (j == i + 1) // all 3 spaces are blank OR the edge of the array
                {
                    // place flower and increment
                    flowerbed[i] = 1;
                    capacity++;
                }
            }
        }
        
        foreach (var e in flowerbed)
            Console.Write("{0},", e);
        
        return n <= capacity;
    }
    
    public bool WithinBounds(int len, int idx)
    {
        return 0 <= idx && idx < len;
    }
}
