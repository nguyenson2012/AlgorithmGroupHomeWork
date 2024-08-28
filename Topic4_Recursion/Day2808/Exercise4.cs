//https://leetcode.com/problems/min-cost-climbing-stairs/

/*
+ To define base case first
    + n = 1 => minimum cost to reach first step is cost[0]
    + n = 2 => minimum cost to reach second step is cost[1]
+ To run for loop from value 2 by adding cost[i] with the minimum cost of 2 previous idexes

Space complexity: O(1)
Time complexity: O(N)
*/

namespace Day2808
{
    public class Exercise4
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            int Length = cost.Length;

            int firstStep = cost[0];
            int secondStep = cost[1];
            for (int i = 2; i < Length; ++i)
            {
                int miniStep = cost[i] + Math.Min(firstStep, secondStep);
                firstStep = secondStep;
                secondStep = miniStep;
            }

            return Math.Min(firstStep, secondStep);
        }
    }
}