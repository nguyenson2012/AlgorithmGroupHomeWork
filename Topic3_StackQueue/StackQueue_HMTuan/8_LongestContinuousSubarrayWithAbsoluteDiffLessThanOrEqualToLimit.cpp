// Time complexity: O(n) 
// Space complexity: O(n) - Using 2 deque  
// Explanation: The code explains itself =)))

class Solution {
public:
    int longestSubarray(vector<int>& nums, int limit) {
        // Using 2 deque to store current max/min elements of window in order 
        // to help track max/min element of current window
        // maxDq/minDq is in descending/ascending order
        deque<int> maxDq;
        deque<int> minDq;

        // Using sliding window technique:
        // "Expand (++right)" the window if not exceed the given limit
        // "Shrink (++left)" the window if exceed the given limit
        int ans = 0;
        int left = 0;  
        for(int right = 0; right < nums.size(); right++){
            int num = nums[right];
            while(!maxDq.empty() && num > maxDq.back()){
                maxDq.pop_back();
            }
            
            while(!minDq.empty() && num < minDq.back()){
                minDq.pop_back();
            }

            maxDq.push_back(num);
            minDq.push_back(num);

            // Check if the max, min of current window > limit -> ++left
            while(maxDq.front() - minDq.front() > limit){
                if (maxDq.front() == nums[left]) {
                    maxDq.pop_front();
                }
                if (minDq.front() == nums[left]) {
                    minDq.pop_front();
                }
                ++left;
            }
            ans = max(ans, right - left + 1);
        } 
        return ans;
    }
};