//https://leetcode.com/problems/merge-sorted-array/description/

/*
+ Using 2 pointers
+ When comparing 2 elements in 2 arrays
    => push the larger element at the end

+ Assign the leftover element of second array into first array

Space complexity: O(1)
Time complexity: O(M + N)  
*/

namespace Day0309
{
    public class Exercise1
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

            while (j >= 0)
                nums1[k--] = nums2[j--];

        }
    }
}