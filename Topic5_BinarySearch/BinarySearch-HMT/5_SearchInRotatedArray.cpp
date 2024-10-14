// Time complexity: O(logn)
// Space complexity: O(1) 
// Explanation: Using custom binary search to detect which sorted side the mid pointer is
// e.g: 3 4 5   1 2 -> The rotated array can be divided into 2 sorted array:
//     [3 4 5] [1 2] -> Check the condition to detect which side.
//     target = 1;
//     mid = 2 , nums[mid] (5) >= nums[left] (3) => mid in the left side
//     Then, check the target is in left side, or right side

class Solution {
public:
    int search(vector<int>& nums, int target) {
        int left = 0, right = nums.size() - 1;
        while(left <= right){
            int mid = (left + right) / 2;
            if(nums[mid] == target){
                return mid;
            }else if(nums[mid] >= nums[left]){
		// Left sorted side
                if (nums[left] <= target && target <= nums[mid]) 
                    right = mid - 1;
                else 
                    left = mid + 1;
            }else{
		// Right sorted side
                if(nums[mid] <= target && target <= nums[right])
                    left = mid + 1;
                else 
                    right = mid - 1;
            }
        }
        return -1;
    }
};