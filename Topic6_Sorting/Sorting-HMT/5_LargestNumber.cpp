// Time complexity: O(n*logn) - sort() function
// Space complexity: O(1) - 2 additional vector left, right
// Explanation: Custom sort to determine which combination of a and b will result in the largest number when concatenated 

class Solution {
public:
    static bool cmp(int a, int b){
        return to_string(a) + to_string(b) > to_string(b) + to_string(a);
    } 

    string largestNumber(vector<int>& nums) {
        sort(nums.begin(), nums.end(), cmp);
        string res;
        for(int num : nums){
            res += to_string(num);
        } 

        if(res[0] == '0') 
            return "0";
        return res;
    }
};