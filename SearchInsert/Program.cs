namespace SearchInsert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[] nums = { 1, 3, 5, 6 };
            int target = 4;

            var response = solution.SearchInsert(nums, target);

            Console.WriteLine(response);
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                    return i;
            }

            return nums.Length;
        }
    }
}
