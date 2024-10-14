// Time complexity: O(n)
// Space complexity: O(n) 
// Explanation: Using hash map to store the frequency of element
//		Decrease the frequency if there is a k-sum pair 

class Solution {
public:
    int maxOperations(vector<int>& nums, int k) {
        unordered_map<int, int> freqMp;
        int maxOps = 0;
        for(int num : nums){
            if(freqMp[k-num] > 0){
                ++maxOps;
                freqMp[k-num]--;
            }else{
                freqMp[num]++;
            }
        }
        return maxOps;
    }
};
