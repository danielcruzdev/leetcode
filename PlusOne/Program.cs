namespace PlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[] digits = { 9, 9, 9 };

            var response = solution.PlusOne(digits);

            Console.WriteLine(response);
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            if(digits.Length == 0) 
                return digits;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            Array.Resize(ref digits, digits.Length + 1); 
            digits[0] = 1;

            return digits;
        }
    }
}
