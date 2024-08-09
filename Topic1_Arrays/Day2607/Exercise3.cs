//https://leetcode.com/problems/maximum-subarray/

/*
+ To sum up the current value into currentSum variable and compare that to result variable to get maximum value
+ However, if current sum is smaller than 0, reset to 0
+ Return the result

Space complexity: O(1)
Time complexity: O(n)
*/

namespace Day2607
{
    public class Exercise3
    {
        public int MaxSubArray(int[] nums)
        {
            int currentSum = 0;
            int result = Int32.MinValue;

            foreach (int num in nums)
            {
                currentSum += num;
                result = Math.Max(result, currentSum);

                if (currentSum < 0)
                    currentSum = 0;

            }


            return result;
        }
    }
}