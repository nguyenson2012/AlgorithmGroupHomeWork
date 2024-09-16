//https://leetcode.com/problems/merge-two-sorted-lists/

/*
+ To use two pointer technique
+ Looping list1 and list2 until 2 lists are totally null
    + If cur val of any lists is not null
        => get current value
    + Otherwise
        => assign it to Max int
    
    + if val of list1 is smaller or equals val of list2 
        => add current pointer of list1 into result
        => move list1 to next pointer
    + Otherwise
        => add current pointer of list2 into result
        => move list2 to next pointer

Space complexity: O(1)
Time complexity: O(Max(m, n)): m is length of list1 and n is lengh of list2
*/

namespace Day0508
{
    public class Exercise2
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummyNode = new(-1);
            ListNode result = dummyNode;

            while (list1 != null || list2 != null)
            {
                int val1 = list1 != null ? list1.val : int.MaxValue;
                int val2 = list2 != null ? list2.val : int.MaxValue;

                if (val1 <= val2)
                {
                    dummyNode.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    dummyNode.next = list2;
                    list2 = list2.next;
                }
                dummyNode = dummyNode.next;
            }

            return result.next;
        }
    }
}