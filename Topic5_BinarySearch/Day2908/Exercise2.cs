//https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/

/*
+ Step 1: work to find the first suitable result (lower_bound)
    + If the middle element is smaller than target value => move to right
    + If the middle element is higher than or equals target value 
        => move to left
        => Assign to first idx if middle element equals to target value
+ Step 2: work to find the second suitable result (upper_bound)
    + If the middle element is smaller than or equals target value 
        => move to right
        => Assign to second idx if middle element equals to target value

    + If the middle element is higher than target value 
        => move to left

Space complexity: O(1)
Time complexity: O(logN)  
*/
namespace Day2908
{
    public class Exercise2
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[2];
            result[0] = -1;
            result[1] = -1;

            if (nums.Length == 0) return result;

            //Step 1: work to find the first suitable result
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] >= target)
                {
                    right = mid - 1;
                    if (nums[mid] == target)
                        result[0] = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            if (result[0] == -1) return result;

            //Step 2: work to find the second suitable result
            left = 0;
            right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] <= target)
                {
                    left = mid + 1;
                    if (nums[mid] == target)
                        result[1] = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }


            return result;
        }
    }
}