// https://leetcode.com/problems/next-permutation/


/*
Space complexity: O(1)
Time complexity: O(n)
*/

namespace Day2607
{
    public class Exercise2
    {
        public void NextPermutation(int[] nums)
        {
            int initialLength = nums.Length;
            if (initialLength == 0 || initialLength == 1) return;

            //Step 1: to loop from the end to find idx1 where nums[i] > nums[i - 1]
            int idx1 = -1;
            for (int i = initialLength - 2; i >= 0; --i)
            {
                if (nums[i] < nums[i + 1])
                {
                    idx1 = i;
                    break;
                }
            }

            if (idx1 == -1)
            {
                Array.Reverse(nums);
                return;
            }

            //Step 2: to loop from the end to find idx2 where nums[i] > nums[idx1]
            int idx2 = -1;
            for (int i = initialLength - 1; i >= 0; --i)
            {
                if (nums[i] > nums[idx1])
                {
                    idx2 = i;
                    break;
                }
            }

            //Step 3: Swap value of idx1 and idx2
            int temp = nums[idx1];
            nums[idx1] = nums[idx2];
            nums[idx2] = temp;

            //Step 4: Reverse array from idx1 + 1 to end
            Array.Reverse(nums, idx1 + 1, initialLength - idx1 - 1);
        }
    }
}