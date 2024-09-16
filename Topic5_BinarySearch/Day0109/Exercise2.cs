//https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/

/*
+ Using binary search technique
+ Find the element at the middle of 2d array
+ If left half is sorted
    => Assign the minimum value at left position into mini variable
    => move to right to search
+ If right half is sorted
    => Assign the minimum value at mid position into mini variable
    => move to left to search

Space complexity: O(1)
Time complexity: O(logN)  
*/

namespace Day0109
{
    public class Exercise2
    {
        public int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int mini = Int32.MaxValue;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[left] <= nums[mid])
                {
                    mini = Math.Min(mini, nums[left]);
                    left = mid + 1;
                }
                else
                {
                    mini = Math.Min(mini, nums[mid]);
                    right = mid - 1;
                }

            }

            return mini;
        }
    }
}