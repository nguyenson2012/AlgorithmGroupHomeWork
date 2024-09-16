//https://leetcode.com/problems/add-two-numbers/

/*
+ We will have 2 pointers when looping 2 lists
    + If current pointer is not null => get current value
    + Otherwise, assign to 0
+ Create node after adding 2 values and leftOver => get remaining
+ Calc leftOver by getting that value / 10

+ At the end, I must check if leftOver equals 0 or not
    + If it doesn't equal 0 => adding that value to result 

Space complexity: O(1)
Time complexity: O(n): 
*/
namespace Day0708
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

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int leftOver = 0;
            ListNode dummyNode = new(-1);
            ListNode result = dummyNode;

            while (l1 != null || l2 != null)
            {
                int val1 = l1 != null ? l1.val : 0;
                int val2 = l2 != null ? l2.val : 0;

                int val = val1 + val2 + leftOver;

                dummyNode.next = new ListNode(val % 10);
                dummyNode = dummyNode.next;

                leftOver = val / 10;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            if (leftOver != 0)
            {
                dummyNode.next = new ListNode(leftOver);
                dummyNode = dummyNode.next;
            }

            return result.next;
        }
    }
}