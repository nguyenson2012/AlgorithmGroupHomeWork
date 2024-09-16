//https://leetcode.com/problems/implement-stack-using-queues/

/*
+ After adding a new element, we will revert queue as stack

Space complexity: O(n)
Time complexity: O(n)
*/

namespace Day1408
{
    public class Exercise1
    {
        public class MyStack
        {
            private Queue<int> queue;

            public MyStack()
            {
                queue = new();
            }

            public void Push(int x)
            {
                queue.Enqueue(x);

                //convert queue into stack
                for (int i = 0; i < queue.Count - 1; i++)
                    queue.Enqueue(queue.Dequeue());
            }

            public int Pop()
            {
                return queue.Dequeue();
            }

            public int Top()
            {
                return queue.Peek();
            }

            public bool Empty()
            {
                return queue.Count == 0;
            }
        }
    }
}