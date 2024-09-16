//https://leetcode.com/problems/find-peak-element/

/*
+ Using binary search technique
+ Eliminate the first and last position

+ Find the element at the middle of 2d array
+ If that element is the peek element 
    => return that position
+ At mid position, if left neighbor is smaller than right neighbor
    => move to right neighbor to get larger element
+ At mid position, if left neighbor is higher than right neighbor
    => move to left neighbor to get larger element

Space complexity: O(1)
Time complexity: O(logN)  
*/

namespace Day0109
{
    public class Exercise3
    {
        public int FindPeakElement(int[] nums)
        {
            int Length = nums.Length;

            if (Length == 1) return 0;

            //eliminate the first and last position
            if (nums[0] > nums[1])
                return 0;

            if (nums[Length - 1] > nums[Length - 2])
                return Length - 1;

            int left = 1;
            int right = Length - 2;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid - 1] < nums[mid] && nums[mid] > nums[mid + 1])
                    return mid;
                else if (nums[mid - 1] < nums[mid])
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }
    }
}