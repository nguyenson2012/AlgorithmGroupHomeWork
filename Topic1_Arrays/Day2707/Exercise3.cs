//https://leetcode.com/problems/majority-element/

/*
+ I will have the candidate variable to compare it to current value in array
+ if candidate equals to currentValue => plus one value into count variable
+ Otherwise, minus 1. If count equals to 0, change value of candidate variable to current value
+ Return the result

Space complexity: O(1)
Time complexity: O(n)
*/
namespace Day2707
{
    public class Exercise3
    {
        public int MajorityElement(int[] nums)
        {
            int length = nums.Length;
            if (length == 1) return nums[0];

            int candidate = nums[0];
            int count = 1;

            for (int i = 1; i < length; ++i)
            {
                if (candidate == nums[i])
                    ++count;
                else
                {
                    --count;
                    if (count == 0)
                    {
                        count = 1;
                        candidate = nums[i];
                    }
                }
            }

            return candidate;
        }
    }
}