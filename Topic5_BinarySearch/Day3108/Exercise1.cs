//https://leetcode.com/problems/search-a-2d-matrix

/*
+ Using binary search technique
+ Find the element at the middle of 2d array
+ To access valid position in 2d array => [mid / col][mid % col]
    + If that element equals to target => return true
    + If that element is smaller than target => that element on left side
    + Otherwise => that element on right side

Space complexity: O(1)
Time complexity: O(logN)  
*/

namespace Day3108
{
    public class Exercise1
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;

            int Length = row * col;

            int left = 0;
            int right = Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (matrix[mid / col][mid % col] == target)
                    return true;
                else if (matrix[mid / col][mid % col] > target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return false;
        }
    }
}