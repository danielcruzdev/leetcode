namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "([{}])";
            var isValid = Solution.IsValid(s);

            Console.WriteLine($"Test: {s} - IsValid? {isValid}");
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public static bool IsValid(string s)
        {
            if(string.IsNullOrWhiteSpace(s)) return false;

            var mappings = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (mappings.ContainsKey(c)) 
                {
                    char topElement = stack.Count == 0 ? '#' : stack.Pop();

                    if (topElement != mappings[c])
                        return false;

                    continue;
                }

                stack.Push(c);     
            }

            return stack.Count == 0;
        }
    }
}
