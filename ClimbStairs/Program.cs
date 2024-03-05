namespace ClimbStairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int n = 5;
            Console.WriteLine($"Response: {solution.ClimbStairs(n)}");
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2)
                return n;

            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }
}
