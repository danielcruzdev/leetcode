namespace DeleteDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            ListNode head = new(1, new(1, new(2, new(3, new(3)))));
            Console.WriteLine($"Response: {solution.DeleteDuplicates(head)}");
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if(head is null || head.next is null)
                return head;

            var current = head;

            while(current.next != null)
            {
                if(current.val == current.next.val)
                    current.next = current.next.next;
                else
                    current = current.next;
            }


            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
