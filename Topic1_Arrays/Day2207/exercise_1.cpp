// Use nested loop to calculate all the possible cases and find the answer
// Time complexity : O(n^2)
// Space complexity: O(1) (because no extra spaces are needed)
#include <bits/stdc++.h>
class Solution {
public:
    void twoSum(vector<int>& nums, int target) {
        for (int i = 0; i < nums.size(); i++) {
            for (int j = i + 1; j < nums.size(); j++) {
                if (nums[i] + nums[j] == target) {
                    //return {i, j};
                }
            }
        }
        //return {-1, -1};
    }
};

