// Time complexity: O(n) 
// Space complexity: O(1) 
// Explanation: Using 3 pointer red, white blue

class Solution {
public:
    void sortColors(vector<int>& nums) {
        // 0 - red
        // 1 - white
        // 2 - blue 
        int r = 0, w = 0, b = nums.size()-1;
        while(w <= b){
            if(nums[w] == 0){
                swap(nums[w], nums[r]);
                ++r;
                ++w;
            }else if(nums[w] == 1){
                ++w;
            }else{
                swap(nums[w], nums[b]);
                --b;
            }
        }
    }
};