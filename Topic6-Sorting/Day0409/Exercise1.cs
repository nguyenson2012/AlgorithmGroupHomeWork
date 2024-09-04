//https://leetcode.com/problems/pancake-sorting/

/*
+ To start with the largest element in array
    + Find idx contaning that element and flip to the front
    + Flip again to make it at the end
    + To decrease larger element and continue looping

Space complexity: O(1)
Time complexity: O(N ^ 2)  
*/

namespace Day0409
{
    public class Exercise1
    {
        public IList<int> PancakeSort(int[] arr)
        {
            int Length = arr.Length;

            List<int> result = new List<int>();

            int count = 0;
            for (int i = Length; i > 1; --i)
            {
                int maxIndex = _findMaxIdxFrom0ToN(arr, i);

                if (maxIndex != i - 1)
                {
                    _flip(arr, maxIndex + 1);
                    result.Add(maxIndex + 1);

                    _flip(arr, i);
                    result.Add(i);
                }
            }

            return result;
        }

        private int _findMaxIdxFrom0ToN(int[] arr, int n)
        {
            int maxIdx = 0;

            for (int i = 1; i < n; ++i)
            {
                if (arr[i] > arr[maxIdx])
                    maxIdx = i;
            }
            return maxIdx;
        }
        private void _flip(int[] arr, int k)
        {
            int left = 0;
            int right = k - 1;

            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                ++left;
                --right;
            }
        }
    }
}