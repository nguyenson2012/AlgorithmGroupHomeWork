//https://leetcode.com/problems/climbing-stairs

/*
+ To define base case first
    + n = 1 => only 1 way to reach the top
    + n = 2 => 2 ways to reach the top
+ To run for loop from value 3 by adding 2 previous steps and update step after that

Space complexity: O(1)
Time complexity: O(N)
*/

namespace Day2808
{
    public class Exercise3
    {
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;

            int step1 = 1;
            int step2 = 2;

            int total = step1 + step2;

            for (int i = 3; i <= n; ++i)
            {
                total = step1 + step2;
                step1 = step2;
                step2 = total;
            }

            return total;
        }
    }
}