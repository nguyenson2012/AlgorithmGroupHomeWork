//https://leetcode.com/problems/kth-largest-element-in-an-array/

/*
+ To store PriorityQueue
+ This PriorityQueue stores k elements from small to biggest
+ When looping every number
    + If PriorityQueue doesn't have enough k elements => add
    + If PriorityQueue has enough k elements => and if peek of 
    PriorityQueue is smaller than current value 
    => deuqueue to remove smallest element in PriorityQueue and add a new value
+ Return the peek of PriorityQueue

Space complexity: O(n)
Time complexity: O(n * klogn)
*/

namespace Day2407
{
    public class Exercise2
    {
        public int FindKthLargest(int[] nums, int k)
        {
            PriorityQueue<int, int> priorityQueue = new();

            foreach (int num in nums)
            {
                if (priorityQueue.Count < k)
                    priorityQueue.Enqueue(num, num);
                else
                {
                    if (priorityQueue.Peek() < num)
                    {
                        priorityQueue.Dequeue();
                        priorityQueue.Enqueue(num, num);
                    }

                }
            }

            return priorityQueue.Peek();
        }
    }
}