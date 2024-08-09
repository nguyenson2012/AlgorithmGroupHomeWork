// https://leetcode.com/problems/linked-list-cycle-ii/

/*
+ To use slow and fast pointer technique
    + slow: move forward one position
    + fast: move forward two positions
+ If slow and fast meet together => a cycle
    + If there is a cycle, I will have the pointer at the beginning
    + This pointer and slow pointer will move forward one position until it reachs
        => A position where a cycle starts
+ There is not a cycle

Space complexity: O(1)
Time complexity: O(n): 
*/
namespace Day0808
{
    public class Exercise2
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
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null) return null;

            ListNode begin = head;
            ListNode slow = head;
            ListNode fast = head;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    while (begin != slow)
                    {
                        begin = begin.next;
                        slow = slow.next;
                    }
                    return begin;
                }
            }
            return null;
        }
    }
}