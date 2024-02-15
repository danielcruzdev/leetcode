namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[] nums = new int[] { 1, 3, 4, 5, 6, 10, 12, 15, 18, 29, 32, 35};
            int target = 16;

            var response = solution.TwoSum(nums, target);

            if(response != null)
            {
                Console.WriteLine(string.Join(",", response));
                return;
            }

            Console.WriteLine("Target not found!");
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var x = nums[i];
                    var y = nums[j];
                    var sum = x + y;

                    if (sum == target)
                        return new int[] { i, j };
                }
            }

            return null;
        }
    }
}