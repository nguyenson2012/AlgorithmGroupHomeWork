//https://leetcode.com/problems/3sum/

/*
+ To sort Array first
+ When looping every element, we will ignore duplicate values, and count 3sum
    + First element: current element
    + Second element: element next to first element
    + Third element: element at the end
+ if sum is 0 => add to result list and move left, and right pointer to valid position (ignore duplicate values)

+ Return result

Space complexity: O(1)
Time complexity: O(n2)
*/

namespace Day2407
{
    public class Exercise3
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);

            IList<IList<int>> result = new List<IList<int>>();

            int length = nums.Length;
            for (int i = 0; i < length - 2; ++i)
            {
                //ignore duplicate values
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int left = i + 1;
                int right = length - 1;

                while (left < right)
                {
                    int threeSum = nums[i] + nums[left] + nums[right];

                    if (threeSum > 0)
                        --right;
                    else if (threeSum < 0)
                        ++left;
                    else
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        ++left;
                        --right;

                        while (nums[left] == nums[left - 1] && left < right)
                            ++left;

                        while (nums[right] == nums[right + 1] && left < right)
                            --right;

                    }
                }
            }

            return result;
        }
    }
}