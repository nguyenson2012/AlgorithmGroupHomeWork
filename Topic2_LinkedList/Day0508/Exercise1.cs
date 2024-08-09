//https://leetcode.com/problems/reverse-linked-list/

/*
+ To use Adding Element at the beginning of Linked list
+ When looping every element, the current element will be added at the beginning

Space complexity: O(1)
Time complexity: O(n)
*/

namespace Day0508
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
    public class Exercise1
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode prev = new(-1);
            ListNode cur = head;

            while (cur != null)
            {
                ListNode next = cur.next;
                ListNode nextPrev = prev.next;

                prev.next = cur;
                cur.next = nextPrev;

                cur = next;

            }
            return prev.next;
        }
    }
}