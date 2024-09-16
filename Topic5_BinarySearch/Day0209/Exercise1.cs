//https://leetcode.com/problems/arranging-coins/

/*
+ Using binary search technique

+ Find the element at the middle of array
    + If that element equals to target => return currentSum
    + If that element is smaller than target => that element on right side
    + Otherwise => that element on left side

Space complexity: O(1)
Time complexity: O(logN)  
*/

namespace Day0209
{
    public class Exercise1
    {
        public int ArrangeCoins(int n)
        {
            int left = 1;
            int right = n;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                long currentSum = (long)mid * (mid + 1) / 2;

                if (currentSum == n)
                    return mid;
                else if (currentSum < n)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return right;
        }
    }
}