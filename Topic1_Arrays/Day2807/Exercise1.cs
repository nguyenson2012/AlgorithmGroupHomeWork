//https://leetcode.com/problems/bag-of-tokens/

/*
Using 2 pointers technique
+ Sort array first
+ For every single loop, there are 3 conditions
    + If current value on left <= power => increase one score, minus power, 
    plus one left, and compare to result variable to get maximum value

    + if score is at least 1 => decrease one score, plus power, 
    minus one right

    + Otherwise, break (doesn't satisfy 2 previos conditions)

+ Return the result

Space complexity: O(1)
Time complexity: O(nlogn)
*/

namespace Day2807
{
    public class Exercise1
    {
        public int BagOfTokensScore(int[] tokens, int power)
        {
            int score = 0;
            int result = 0;
            int left = 0;
            int right = tokens.Length - 1;

            Array.Sort(tokens);

            while (left <= right)
            {
                if (tokens[left] <= power)
                {
                    power -= tokens[left];
                    ++score;
                    ++left;
                    result = Math.Max(result, score);
                }
                else if (score >= 1)
                {
                    power += tokens[right];
                    --score;
                    --right;
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}