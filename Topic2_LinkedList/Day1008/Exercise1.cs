//https://leetcode.com/problems/remove-duplicates-from-sorted-list/

/*
+ I am going to have 2 pointers, previous and current
    + If previous value equals current value => delete current by connecting previous pointer with next pointer
    + Otherwise, move prev pointer into next position
+ Move cur pointer into next position

Space complexity: O(1)
Time complexity: O(n)
*/

namespace Day1008
{
    public class Exercise1
    {
        //   Definition for singly-linked list.
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
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode result = head;

            ListNode prev = head;
            ListNode cur = head.next;

            while (cur != null)
            {
                ListNode next = cur.next;

                if (prev.val == cur.val)
                    prev.next = next;
                else
                    prev = cur;

                cur = next;
            }
            return result;
        }
    }
}