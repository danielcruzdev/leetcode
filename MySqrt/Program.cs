namespace MySqrt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int x = 165;

            var response = solution.MySqrt(x);

            Console.WriteLine(response);
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public int MySqrt(int x)
        {
            if (x == 0 || x == 1)
                return x;

            long left = 1, right = x, ans = 0;
            while (left <= right)
            {
                long mid = left + (right - left) / 2;

                if (mid * mid == x)
                    return (int)mid;

                if (mid * mid < x)
                {
                    left = mid + 1;
                    ans = mid;
                }
                else
                    right = mid - 1;   
            }

            return (int)ans;
        }
    }
}
