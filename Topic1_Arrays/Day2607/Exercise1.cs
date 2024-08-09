//https://leetcode.com/problems/contiguous-array/description/


/*
+ To store [key, value] ([currentSum, position]) in dictionary
+ I will have sum variable to sum all the elements from the beginning to current position. If value is 1, plus 1 otherwise minus 1 
+ At every position, I will find whether key: currentSum exists in dictionary or not. If it exists, it means that 
there's definetely a contiguous array => count new result
+ To add current sum with with current position into dictionary if current sum doesn't exist
+ Return the result

Space complexity: O(n)
Time complexity: O(n)
*/


namespace Day2607
{
    public class Exercise1
    {
        public int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> myDict = new();
            myDict[0] = -1;

            int sum = 0;
            int result = 0;
            int initialLength = nums.Length;

            for (int i = 0; i < initialLength; ++i)
            {
                sum += nums[i] == 1 ? 1 : -1;

                if (myDict.ContainsKey(sum))
                    result = Math.Max(result, i - myDict[sum]);

                if (!myDict.ContainsKey(sum))
                    myDict[sum] = i;
            }

            return result;
        }
    }
}