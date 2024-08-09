//https://leetcode.com/problems/random-pick-with-weight/description/

/*
+ To use Binary Search technique
+ To calculate sum of the array
+ To build array where each value will show the range between [0, 1] 
    + For example: 
    [1, 3, 2, 4]
    sum = 10
    [0.1, 0.4, 0.6, 1.0]
+ To find idx using Binary search. 
    + If current value is smaller than randomNumber => left = mid + 1;
    + Otherwise => right = mid

+ Return left idx

Space complexity: O(n)
Time complexity: O(n)
*/

namespace Day2307
{
    public class Solution
    {
        private double[] weights;
        private int _sum = 0;
        private Random random = new Random();

        public Solution(int[] w)
        {
            weights = new double[w.Length];
            _sum = w.Sum();

            int prevSum = 0;
            for (int i = 0; i < w.Length; ++i)
            {
                prevSum += w[i];
                weights[i] = prevSum * 1.0 / _sum;
            }
        }

        public int PickIndex()
        {
            double randomNumber = random.NextDouble();

            int left = 0;
            int right = weights.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (weights[mid] < randomNumber)
                    left = mid + 1;
                else
                    right = mid;
            }

            return left;
        }
    }
}