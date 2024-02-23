namespace MergeTwoLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list1 = new ListNode(2, new ListNode(3, new ListNode(5)));
            var list2 = new ListNode(1, new ListNode(4, new ListNode(6)));

            var solution = new Solution();

            var shortedList = solution.MergeTwoLists(list1, list2);

            Console.WriteLine(shortedList);
        }
    }

    //Solution posted in LeetCode :)
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            var mergedList = new ListNode();
            var current = mergedList;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            if (list1 != null)
                current.next = list1;
            
            if (list2 != null)
                current.next = list2;
            
            return mergedList.next;
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
