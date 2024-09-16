//https://leetcode.com/problems/search-in-rotated-sorted-array/

/*
+ Using binary search technique
+ Find the element at the middle of 2d array
+ If left half is sorted
    + If target is in the range of left half => move to left
    + Otherwise => move to right
+ If right half is sorted
    + If target is in the range of right half => move to right
    + Otherwise => move to left

Space complexity: O(1)
Time complexity: O(logN)  
*/

namespace Day0109
{
    public class Exercise1
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                    return mid;
                //left is sorted
                else if (nums[left] <= nums[mid])
                {
                    if (nums[left] <= target && target <= nums[mid])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                //right is sorted
                else
                {
                    if (nums[mid] <= target && target <= nums[right])
                        left = mid + 1;
                    else
                        right = mid - 1;
                }

            }
            return -1;
        }
    }
}