//https://leetcode.com/problems/first-bad-version/

/*
+ Using binary search technique
+ Find the element at the middle of array
    + If that element is a bad version => move to left to search
    + Otherwise => move to right to search

Space complexity: O(1)
Time complexity: O(logN)  
*/

namespace Day3008
{
    public class Exercise2
    {
        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return left;
        }
    }
}