public class Solution {
    public IList<string> FizzBuzz(int n) {
        string[] answer = new string[n];
        int oneBaseIdx = 1;
        for (int i = 0; i < n; i++)
        {
            answer[i] = oneBaseIdx % 15 == 0
                ? "FizzBuzz"
                : oneBaseIdx % 3 == 0
                ? "Fizz"
                : oneBaseIdx % 5 == 0
                ? "Buzz"
                : oneBaseIdx + "";
            oneBaseIdx++;
        }
        return answer;
    }
}
