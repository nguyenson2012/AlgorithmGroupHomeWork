// Time complexity: O(log n * m) - n is row, m is column
// Space complexity: O(1)
// Explanation: Convert 2d matrix -> 1d array

class Solution {
public:
    bool searchMatrix(vector<vector<int>>& matrix, int target) {
        int rows = matrix.size();
        int cols = matrix[0].size();
        int matrixSize = rows * cols; 
        int left = 0, right = matrixSize - 1; // start from 0, so need to -1
	
	// Bisearch
        while(left <= right){
	    // convert from index of 1d array -> 2d matrix
            int mid = (left + right) / 2;
            int midRow = mid / cols;
            int midCol = mid % cols;

            if(matrix[midRow][midCol] == target){
                return true;
            }else if(matrix[midRow][midCol] > target){
                right = mid - 1;
            }else{
                left = mid + 1;
            }
        } 
        return false;
    }
};