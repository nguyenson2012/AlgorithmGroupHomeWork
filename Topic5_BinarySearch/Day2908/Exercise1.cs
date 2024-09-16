//https://leetcode.com/problems/binary-search/

/*
+ Using binary search technique
+ Find the element at the middle of array
    + If that element equals to target => return true
    + If that element is smaller than target => that element on left side
    + Otherwise => that element on right side

Space complexity: O(1)
Time complexity: O(logN)  
*/

namespace Day2908
{
    public class Exercise1
    {
        public int Search(int[] nums, int target)
        {
            int result = -1;

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return result;
        }
    }
}