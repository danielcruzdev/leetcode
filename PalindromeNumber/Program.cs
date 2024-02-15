namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int number = 123;

            var isPalindrome = solution.IsPalindrome(number);

            Console.WriteLine($"Number: {number} is a palindrome? {isPalindrome}");
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public bool IsPalindrome(int number)
        {
            if (number < 0)
                return false;
            
            if (number % 10 == 0 & number != 0)
                return false;
            
            int x1 = number;
            int rev = 0;

            while (x1 > 0)
            {
                rev = rev * 10 + x1 % 10;
                x1 /= 10;
            }

            return rev == number;
        }
    }
}