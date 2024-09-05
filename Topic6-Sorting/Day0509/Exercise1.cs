//https://leetcode.com/problems/sort-an-array/

/*
+ To get the last element of array as pivot
    + To move all elements less than pivot on the left
    + To move all elements greater than pivot on the right
    + To move that pivot element at the right position

Space complexity: O(N)
Time complexity: O(N ^ 2)  
*/
namespace Day0509
{
    public class Exercise1
    {
        public int[] SortArray(int[] nums)
        {
            _quickSort(nums, 0, nums.Length - 1);

            return nums;
        }

        private void _quickSort(int[] nums, int start, int end)
        {
            if (start >= end) return;

            int pivot = _partition(nums, start, end);
            _quickSort(nums, start, pivot - 1);
            _quickSort(nums, pivot + 1, end);
        }

        private int _partition(int[] nums, int start, int end)
        {
            int i = start - 1;
            int j = start;

            while (j < end)
            {
                if (nums[j] < nums[end])
                    _swap(ref nums[++i], ref nums[j]);

                j++;
            }

            _swap(ref nums[++i], ref nums[j]);

            return i;
        }

        private void _swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}