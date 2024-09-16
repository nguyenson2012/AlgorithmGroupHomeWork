//https://leetcode.com/problems/sort-list/

/*
+ To use merge sort technique
    + To get the middle element of linked list
    + To run recursive call on left
    + To run recursive call on right
    + Merge them toegether

Space complexity: O(log N * (N + N / 2)) recursive stack space
Time complexity: O(N LogN)  
*/

namespace Day0609
{
    public class Exercise2
    {
        public ListNode SortList(ListNode head)
        {
            return _mergeSort(head);
        }

        private ListNode _mergeSort(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode middle = _findMiddleNode(head);

            ListNode leftHead = head;
            ListNode rightHead = middle.next;

            middle.next = null;

            leftHead = _mergeSort(leftHead);
            rightHead = _mergeSort(rightHead);

            return _merge(leftHead, rightHead);
        }

        private ListNode _findMiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head.next;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }

        private ListNode _merge(ListNode list1, ListNode list2)
        {
            ListNode dummyNode = new(-1);
            ListNode result = dummyNode;

            while (list1 != null || list2 != null)
            {
                int val1 = list1 != null ? list1.val : Int32.MaxValue;
                int val2 = list2 != null ? list2.val : Int32.MaxValue;

                ListNode temp = new(-1);
                if (val1 >= val2)
                {
                    temp = new(val2);
                    if (list2 != null) list2 = list2.next;
                }
                else
                {
                    temp = new(val1);
                    if (list1 != null) list1 = list1.next;
                }
                dummyNode.next = temp;
                dummyNode = dummyNode.next;
            }

            return result.next;
        }
    }
}