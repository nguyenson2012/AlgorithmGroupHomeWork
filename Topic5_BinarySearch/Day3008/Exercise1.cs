//https://leetcode.com/problems/sqrtx/

/*
+ Using binary search technique
+ Find the element at the middle of array
    + If that element multiples together is lower than or equals to target => move to right to search
    + Otherwise => move to left to search

Space complexity: O(1)
Time complexity: O(logN)  
*/

namespace Day3008
{
    public class Exercise1
    {
        public int MySqrt(int x)
        {
            long left = 1;
            long right = x;

            while (left <= right)
            {
                long mid = left + (right - left) / 2;
                long val = mid * mid;

                if (val <= x)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return (int)right;
        }
    }
}