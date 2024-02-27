﻿namespace FindTheIndexString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            string haystack = "aabaaabaaac";
            string needle = "aabaaac";

            var response = solution.StrStr(haystack, needle);

            Console.WriteLine(response);
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length > haystack.Length) return -1;
            
            for (int i = 0; i <= haystack.Length - needle.Length; ++i)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                    return i;         
            }

            return -1;
        }
    }
}
