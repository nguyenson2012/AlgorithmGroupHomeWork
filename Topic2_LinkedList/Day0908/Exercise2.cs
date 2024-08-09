//https://leetcode.com/problems/palindrome-linked-list/description/

/*
+ To use slow and fast pointer technique in Linked List
+ To reverse Linked List at slow pointer
+ To compare 2 values at begin and slow pointer
    => if it's different => false

+ return true;

Space complexity: O(1)
Time complexity: O(n)
*/

namespace Day0908
{
    public class Exercise2
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
        public bool IsPalindrome(ListNode head)
        {
            if (head.next == null) return true;

            ListNode begin = head;
            ListNode slow = head;
            ListNode fast = head;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            slow = _reverseList(slow);

            while (slow != null)
            {
                if (begin.val != slow.val)
                    return false;

                begin = begin.next;
                slow = slow.next;

            }

            return true;
        }

        private ListNode _reverseList(ListNode head)
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