//https://leetcode.com/problems/remove-nth-node-from-end-of-list/

/*
+ To add dummyNode at the beginning of head
+ We will have 2 pointers
    + First: at dumymNode
    + Second: at head
+ We will move second pointer first within n times
    + If second pointer is null => remove the first element
+ And move second pointer until it reachs null of head, along with first pointer
+ Update first pointer

Space complexity: O(1)
Time complexity: O(n): 
*/

namespace Day0608
{
    public class Exercise2
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummyNode = new(-1);
            dummyNode.next = head;

            ListNode first = dummyNode;
            ListNode second = head;

            for (int i = 1; i <= n; ++i)
                second = second.next;

            if (second == null) return head.next;

            while (second != null)
            {
                first = first.next;
                second = second.next;
            }

            first.next = first.next.next;

            return dummyNode.next;

        }
    }
}