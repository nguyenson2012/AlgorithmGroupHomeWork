//https://leetcode.com/problems/reveal-cards-in-increasing-order/

/*
Using queue technique
+ To sort array
+ To initialize Queue to store idx from 0 => length - 1 of deck array
+ When looping array deck, get current idx in Queue and assign current value of card into value at idx of result
+ If there still exists any indices in Queue, dequeue and add it to the end of Queue

+ Return result


Space complexity: O(n)
Time complexity: O(nlogn)
*/

namespace Day2807
{
    public class Exercise3
    {
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            // Sort the deck
            Array.Sort(deck);

            // Initialize a queue to store the indices
            // Indices is a list of idx of deck array
            Queue<int> indices = new Queue<int>(Enumerable.Range(0, deck.Length));

            // Initialize the result array
            int[] result = new int[deck.Length];

            // Iterate over sorted deck and populate result array
            foreach (var card in deck)
            {
                // Take the index of the next unrevealed card
                int idx = indices.Dequeue();
                // Assign the revealed card to the correct position
                result[idx] = card;

                // If there are still unrevealed cards, move the next unrevealed card to the end
                if (indices.Count > 0)
                    indices.Enqueue(indices.Dequeue());

            }

            return result;
        }
    }
}