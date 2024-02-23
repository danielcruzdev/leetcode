namespace RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var nums = new int[] { 3, 2, 2, 3 };
            int val = 3;

            var response = solution.RemoveElement(nums, val);

            Console.WriteLine(response);
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int cont = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[cont] = nums[i];
                    cont++;
                }

            }

            return cont;
        }
    }
}
