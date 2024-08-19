//https://leetcode.com/problems/number-of-recent-calls/

/*
+ When receiving t I must ensure that
    + queue is in range [t - 3000, t]
    + Otherwise, dequeue the front element

Space complexity: O(n)
Time complexity: O(n)
*/

namespace Day1808
{
    public class Exercise1
    {
        public class RecentCounter
        {
            private Queue<int> queue;
            public RecentCounter()
            {
                queue = new();
            }

            public int Ping(int t)
            {
                int mini = t - 3000;
                int maxi = t;

                queue.Enqueue(t);

                while (queue.Count != 0 && (mini > queue.Peek() || queue.Peek() > maxi))
                    queue.Dequeue();

                return queue.Count;
            }
        }
    }
}