//https://leetcode.com/problems/sort-colors/

/*
+ Using 3 pointers
    + Left pointer: [0, left - 1] is 0 value
    + Mid pointer: to iterate
    + Right Pointer [Right + 1, Length - 1] is 2 value

+ When looping with arr we will have 3 value
    + With 0: swap current mid pointer with left pointer => increate top, mid pointer
    + With 1: ignore that
    + With 2: swap current mid pointer with right pointer => decrease right pointer

Space complexity: O(1)
Time complexity: O(N)  
*/

namespace Day0409
{
    public class Exercise2
    {
        public void SortColors(int[] nums)
        {
            int red = 0;
            int white = 0;
            int blue = nums.Length - 1;

            while (white <= blue)
            {
                if (nums[white] == 0)
                {
                    Swap(ref nums[red], ref nums[white]);
                    ++red;
                    ++white;
                }
                else if (nums[white] == 1)
                {
                    ++white;
                }
                else
                {
                    Swap(ref nums[white], ref nums[blue]);
                    --blue;
                }
            }
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}