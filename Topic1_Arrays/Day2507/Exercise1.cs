//https://leetcode.com/problems/container-with-most-water/description/


/*
Use Two pointers technique
+ I will have 2 pointers at the beginning and at the end
+ For every loop, i will calc the current area => assign it to result if current result is smaller
+ Because max area must have the maximum width and maximum height. Therefore, if current pointer left
is smaller than pointer right, I will move pointer left to right to find bigger height. Converserly,
if current pointer right is smaller than pointer left, I will move pointer right to left to find bigger height
+ Return the result


Space complexity: O(1)
Time complexity: O(n)
*/


namespace Day2507
{
    public class Exercise1
    {
        public int MaxArea(int[] arr) 
        {
            int initialLength = arr.Length;
            int result = 0;
            int left = 0;
            int right = initialLength - 1;


            while(left < right)
            {
                int width = right - left;
                int height = Math.Min(arr[left], arr[right]);
                int calcArea = width * height;

                result = Math.Max(result, calcArea);

                if(arr[left] < arr[right])
                    ++left;
                else
                    --right;

            }
            return result;
        }
    }
}