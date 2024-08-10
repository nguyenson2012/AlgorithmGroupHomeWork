//https://leetcode.com/problems/merge-k-sorted-lists/

/*
+ Using priorityQueue
    + Push all the first element in every single list of lists

+ Iterating until that queue is empty
    + For every loop, get the first element 
        => push it into result list 
        => push the next element of the first element in list into queue

Space complexity: O(n)
Time complexity: O((k * n * logk) + (k * logk))
*/
namespace Day1008
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
        public ListNode MergeKLists(ListNode[] lists)
        {
            //k: the length of lists
            //n: the length of every list in lists
            int length = lists.Length;

            if (length == 0) return null;

            ListNode dummyNode = new(-1);
            ListNode result = dummyNode;

            PriorityQueue<ListNode, int> priorityQueue = new();

            foreach (ListNode list in lists)
            {
                if (list != null)
                    priorityQueue.Enqueue(list, list.val); // k * logk
            }


            while (priorityQueue.Count > 0) // k * n 
            {
                ListNode item = priorityQueue.Dequeue();// logk

                dummyNode.next = item;
                dummyNode = dummyNode.next;

                if (item.next != null)
                    priorityQueue.Enqueue(item.next, item.next.val);// logk

            }
            //  => k * n * logk

            return result.next;
        }
    }
}