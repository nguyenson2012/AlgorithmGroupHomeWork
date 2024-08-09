//https://leetcode.com/problems/merge-sorted-array/

/*
+ I will have 2 pointers at the end of every array
+ when comparing 2 current values in array, I need to move larger value into the end of array
+ Fill all remaining values of nums2 array into nums1 array

Space complexity: O(m + n)
Time complexity: O(1)
*/

namespace Day2207
{
    public class Exercise3
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = nums1.Length - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] >= nums2[j])
                    nums1[k--] = nums1[i--];
                else
                    nums1[k--] = nums2[j--];
            }


            //fill all remaining elements in nums2 array into nums1 array
            while (j >= 0)
                nums1[k--] = nums2[j--];
        }
    }
}