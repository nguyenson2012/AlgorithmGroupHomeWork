//https://leetcode.com/problems/sort-an-array/description/

/*
+ Using merge sort technique
+ Divide arr into 2 half and sort every half
+ After that, merge 2 half together => become an sorted array

Space complexity: O(N)
Time complexity: O(NlogN)  
*/

namespace Day0309
{
    public class Exercise2
    {
        public int[] SortArray(int[] nums)
        {
            MergeSort(nums, 0, nums.Length - 1);
            return nums;
        }

        private void MergeSort(int[] nums, int left, int right)
        {
            if (left == right)
                return;

            int mid = left + (right - left) / 2;

            MergeSort(nums, left, mid);
            MergeSort(nums, mid + 1, right);
            Merge(nums, left, mid, right);
        }

        private void Merge(int[] nums, int left, int mid, int right)
        {
            int m = mid - left + 1;
            int n = right - mid;

            int[] leftArr = new int[m];
            int[] rightArr = new int[n];

            for (int z = 0; z < m; ++z)
                leftArr[z] = nums[left + z];

            for (int z = 0; z < n; ++z)
                rightArr[z] = nums[mid + 1 + z];

            int i = 0;
            int j = 0;
            int k = left;

            while (i < m && j < n)
            {
                if (leftArr[i] >= rightArr[j])
                    nums[k++] = rightArr[j++];
                else
                    nums[k++] = leftArr[i++];
            }

            while (i < m)
                nums[k++] = leftArr[i++];

            while (j < n)
                nums[k++] = rightArr[j++];

        }
    }
}