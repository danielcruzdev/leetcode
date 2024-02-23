namespace RemoveDuplicatesSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            var response = solution.RemoveDuplicates(nums);

            Console.WriteLine(response);
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int i = 1;

            foreach (int n in nums)
            {
                if (nums[i - 1] != n) 
                    nums[i++] = n;
            }

            return i;
        }
    }
}
