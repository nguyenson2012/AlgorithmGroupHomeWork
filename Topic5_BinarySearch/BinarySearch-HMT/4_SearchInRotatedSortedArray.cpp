// Time complexity: O(log n)
// Space complexity: O(1) 
// Explanation: Custom binary search
//		Using min_ele to handle some special case of rotated sorted array

class Solution {
public:
    int findMin(vector<int>& nums) {
        int left = 0, right = nums.size() - 1;
        int min_ele = nums[0];
        while(left <= right){
            int mid = (left + right) / 2;
            if(nums[mid] <= nums[right]){
                min_ele = min(min_ele, nums[mid]);
                right = mid - 1;
            }else{
                left = mid + 1;
            }
        }
        return min_ele;
    }
};