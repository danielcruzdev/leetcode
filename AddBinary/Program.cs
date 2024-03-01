namespace AddBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var a = "1111";
            var b = "1000";

            var response = solution.AddBinary(a, b);

            Console.WriteLine(response);
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            int carry = 0;
            int i = a.Length - 1;
            int j = b.Length - 1;
            string result = "";

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry;
                if (i >= 0)
                {
                    sum += a[i] - '0';
                    i--;
                }
                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;
                }

                result = (sum % 2) + result;
                carry = sum / 2;
            }

            return result;
        }
    }
}
