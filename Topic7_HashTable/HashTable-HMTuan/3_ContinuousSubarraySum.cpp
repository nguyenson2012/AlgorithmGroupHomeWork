// Time complexity: O(n)
// Space complexity: O(n) 
// Explanation: Using hash map and prefixSum
//		*note: initial case where prefixSum = 0 at index -1 

class Solution {
public:
    bool checkSubarraySum(vector<int>& nums, int k) {
        // prefixMod store <remainder, index> pairs
        unordered_map<int, int> prefixMod;
        int sum = 0;

        // Handle the case where prefixSum = 0 at index -1 
        // Ex:      nums:   1 4 3 1 3      k = 6
        //     prefixSum: 0 1 5 8 9 12
        //     prefixMod: 0 1 5 2 3 0
        prefixMod[0] = -1;

        for(int i = 0; i < nums.size(); i++){
            sum += nums[i];
            int remainder = sum % k; 
            if(prefixMod.find(remainder) != prefixMod.end()){
                // Make sure that the subarray length is at least 2
                if(i > prefixMod[remainder] + 1)
                    return true;
            }else{
                prefixMod[remainder] = i;
            }
        } 
        return false;
    }
};