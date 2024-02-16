namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            string[] strs = new string[] { "flower", "flow", "flight" };
            var prefix = solution.LongestCommonPrefix(strs);

            Console.WriteLine($"Prefix: {prefix}");
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string shortest = strs.OrderBy(s => s.Length).First();

            for (int i = 0; i < shortest.Length; i++)
            {
                if (strs.Select(s => s[i]).Distinct().Count() > 1) 
                    return shortest[..i];
            }

            return shortest;
        }
    }
}