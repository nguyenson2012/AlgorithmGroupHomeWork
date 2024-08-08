//https://leetcode.com/problems/linked-list-cycle/

/*
+ To use slow and fast pointer technique
    + slow: move forward one position
    + fast: move forward two positions
+ If slow and fast meet together => a cycle

Space complexity: O(1)
Time complexity: O(n): 
*/

namespace Day0808
{
    public class Exercise1
    {
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
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;

            ListNode slow = head;
            ListNode fast = head.next;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast) return true;
            }
            return false;
        }
    }
}