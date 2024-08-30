//https://leetcode.com/problems/valid-perfect-square/

/*
+ Using binary search technique
+ Find the element at the middle of array
    + If that element multiples together equals to target => return true
    + If that element multiples together is lower than target => move to right to search
    + Otherwise => move to left to search

Space complexity: O(1)
Time complexity: O(logN)  
*/

namespace Day3008
{
    public class Exercise3
    {
        public bool IsPerfectSquare(int num)
        {
            Int64 left = 1;
            Int64 right = num;

            while (left <= right)
            {
                Int64 mid = left + (right - left) / 2;

                Int64 temp = mid * mid;

                if (temp == num)
                    return true;
                else if (temp < num)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return false;
        }
    }
}