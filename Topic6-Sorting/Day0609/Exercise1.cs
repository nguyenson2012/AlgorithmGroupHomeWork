//https://leetcode.com/problems/merge-two-sorted-lists/

/*
+ To use 2 pointers technique
    + if a value of first pointer is larger than a value of second pointer
        => add value of second pointer into result
        => move forward that second pointer
    + Otherwise
        => add value of first pointer into result
        => move forward that first pointer

Space complexity: O(1)
Time complexity: O(Max(M, N))  
*/

namespace Day0609
{
    public class Exercise1
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
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