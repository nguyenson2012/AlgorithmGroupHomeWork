//https://leetcode.com/problems/top-k-frequent-elements/

/*
+ I will add every element into dictionary based on its occurence
+ After that, I will add top-k elements into heap with current value based on its occurence.
If occurence is low, it will be dequeued from the minHeap
+ Add everything in minHeap into list array

+ Return the result

Space complexity: O(n^2)
Time complexity: O(klogn) (k is required in parameters)
*/

namespace Day2707
{
    public class Exercise2
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> myDict = new();
            PriorityQueue<int, int> minHeap = new();

            foreach (int num in nums)
            {
                if (myDict.ContainsKey(num))
                    myDict[num]++;
                else
                    myDict[num] = 1;
            }

            foreach (var kvp in myDict)
            {
                minHeap.Enqueue(kvp.Key, kvp.Value);

                if (minHeap.Count > k)
                    minHeap.Dequeue();
            }

            List<int> list = new();
            while (minHeap.Count > 0)
                list.Add(minHeap.Dequeue());

            return list.ToArray();
        }
    }
}