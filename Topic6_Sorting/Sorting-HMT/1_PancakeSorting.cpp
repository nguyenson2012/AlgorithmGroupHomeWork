// Time complexity: O(n^2)
// Space complexity: O(1)
// Explanation: Idea is same as Subble Sort. 
//		After each sorting step (i.e bubble the biggest element on the right), fix the end of array and handle the rest.

class Solution {
public:
    vector<int> pancakeSort(vector<int>& arr) {
        int n = arr.size();
        vector<int>ans;
        for(int i = n; i >= 1; i--){
            for(int j = 0; j < n - 1; j++){
                // If the left ptr is equal to right ptr (i.e ), we move the left ptr to the right ptr and fix the tail
                if(arr[j] == i){
                    // Reverse to move left ptr to the head of arr
                    reverse(arr.begin(), arr.begin() + j + 1);
                    ans.push_back(j + 1);

                    // Reverse to move head of arr to the tail of arr
                    reverse(arr.begin(), arr.begin() + i);
                    ans.push_back(i);
                }
            }
        }
        return ans;
    }
};