//https://leetcode.com/problems/find-the-winner-of-the-circular-game/

/*
+ Add idx element into array
+ Looping queue until there is only one element
    + To ignore k - 1 element and push it into queue
    + to dequeue k element

Space complexity: O(n)
Time complexity: O(n * k)
*/

namespace Day1708
{
    public class Exercise2
    {
        public int FindTheWinner(int n, int k)
        {
            Queue<int> queue = new();
            --k;

            for (int i = 1; i <= n; ++i)
                queue.Enqueue(i);

            while (queue.Count > 1)
            {
                for (int i = 0; i < k; ++i)
                    queue.Enqueue(queue.Dequeue());

                queue.Dequeue();

            }

            return queue.Peek();
        }
    }
}