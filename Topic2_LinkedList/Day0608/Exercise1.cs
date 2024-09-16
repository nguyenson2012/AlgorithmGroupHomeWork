// /https://leetcode.com/problems/reorder-list/description/

/*
+ Step 1: to place slow and fast pointers at right position
+ Step 2: reverse list from the fast pointer to the end
+ Step 3: merge 2 lists

Space complexity: O(1)
Time complexity: O(n): 
*/

namespace Day0608
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
        public void ReorderList(ListNode head)
        {
            //move slow and fast pointers to the right position
            ListNode slow = head;
            ListNode fast = head.next;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            //reverse second half of the list
            ListNode first = head;
            ListNode second = ReverseList(slow.next);
            slow.next = null;

            //merge 2 lists into first pointer
            Merge(first, second);

        }

        private ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;

            ListNode cur = head;

            while (cur != null)
            {
                ListNode next = cur.next;

                cur.next = prev;
                prev = cur;
                cur = next;
            }

            return prev;
        }

        private void Merge(ListNode first, ListNode second)
        {
            while (first != null)
            {
                ListNode firstNext = first.next;
                ListNode secondNext = second != null ? second.next : null;

                first.next = second;

                if (firstNext == null) return;

                second.next = firstNext;

                first = firstNext;
                second = secondNext;
            }
        }
    }
}