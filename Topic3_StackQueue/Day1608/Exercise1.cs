//https://leetcode.com/problems/reveal-cards-in-increasing-order/

/*
+ Sort array first
+ Add position of all elements into queue

+ When looping every element in array
    + Assign the current element into (the position of the front element in queue)
    + Move the next position to the end

Space complexity: O(n)
Time complexity: O(n)
*/
namespace Day1608
{
    public class Exercise1
    {
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            Array.Sort(deck);

            Queue<int> queue = new();

            int length = deck.Length;

            int[] result = new int[length];

            for (int i = 0; i < length; ++i)
                queue.Enqueue(i);

            foreach (int num in deck)
            {
                int position = queue.Dequeue();
                result[position] = num;

                if (queue.Count != 0)
                    queue.Enqueue(queue.Dequeue());
            }

            return result;
        }
    }
}