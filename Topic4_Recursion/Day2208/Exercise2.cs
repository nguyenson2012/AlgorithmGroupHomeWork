//https://leetcode.com/problems/reorder-list/

/*
+ Move to get the last element in linked list
+ Add that last element between current zipper and zipperNext
+ Continue to loop the next element (ignoring the element which is added recently)

Space complexity: O(N)
Time complexity: O(N)
*/

namespace Day2208
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
    public class Exercise2
    {
        ListNode start;

        public void ReorderList(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null) return;
            start = head;
            scanNext(head); // Recursion builds the output list.
        }


        private void scanNext(ListNode node)
        {
            if (node == null) return; // If end of input list, start returning from recursion.

            scanNext(node.next); // If more input list, keep recursing.

            if (start.next == null) return; // Unwinding from recursion.  If output list done, then do nothing
            ListNode startNext = start.next; // Save next node from first half of list.

            // If first-half and second-half met in middle, then done merging.
            if (start == node)
                start.next = null;
            else
            {
                //used for list has even length
                if (node == startNext)
                {
                    start = node;
                    start.next = null;

                    //used for list has odd length
                }
                else
                {
                    node.next = startNext; // Finish inserting node from recursion/second-half
                    start.next = node;

                    start = startNext;
                }
            }
        }
    }
}