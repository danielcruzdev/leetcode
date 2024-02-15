namespace RomanToInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var romanNumber = "MCMXCIV";
            var number = solution.RomanToInt(romanNumber);

            Console.WriteLine($"Roman Number {romanNumber} - Number: {number}");
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public int RomanToInt(string s)
        {
            var romanNumers = new Dictionary<char, int>() 
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            if(string.IsNullOrWhiteSpace(s)) 
                return 0;

            int[] numbers = s.Select(x => romanNumers.GetValueOrDefault<char, int>(x)).ToArray();

            var number = 0;
            for(int i = 0; i < numbers.Length;)
            {
                if (i + 1 > numbers.Length - 1)
                {
                    number += numbers[i];
                    break;
                }

                if (numbers[i] < numbers[i + 1])
                {
                    number += numbers[i + 1] - numbers[i];
                    i += 2;
                    continue;
                }

                number += numbers[i];
                i++;
            }

            return number;
        }
    }
}