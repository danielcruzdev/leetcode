using System.Text.RegularExpressions;

namespace LengthOfLastWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            string s = "   fly me   to   the moon  ";

            var response = solution.LengthOfLastWord(s);

            Console.WriteLine(response);
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            string lastWord = string.Empty;
            bool foundSpace = false;

            for (int i = 0; i < s.Length; i++) 
            {
                if (s[i] != ' ')
                {
                    if (foundSpace)
                    {
                        foundSpace = false;
                        lastWord = string.Empty;
                    }
                    
                    lastWord += $"{s[i]}";
                    continue;
                }
                
                foundSpace = true;
            }

            return lastWord.Length;
        }
    }
}
